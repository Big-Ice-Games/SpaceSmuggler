using System;
using System.Collections;
using System.Collections.Generic;
using BIG;

#pragma warning disable CS8625

namespace SpaceSmuggler
{
    /// <summary>
    /// Store actions and coroutines that can be executed in main game loop.
    /// </summary>
    public sealed class MainThreadActionQueue
    {
        public class DelayedAction
        {
            public Action Action;
            public float TimeToGo;
            public DelayedAction(Action action, float timeToGo)
            {
                Action = action;
                TimeToGo = timeToGo;
            }
        }

        private readonly Queue<Action> _threadedActions;
        private readonly Queue<IEnumerator> _coroutines;
        private readonly DelayedAction?[] _delayedActions;

        /// <summary>
        /// Not cleaned on Clear.
        /// </summary>
        private readonly Queue<Action> _persistentActions;

        public MainThreadActionQueue()
        {
            _threadedActions = new Queue<Action>(48);
            _coroutines = new Queue<IEnumerator>(24);
            _delayedActions = new DelayedAction[24];
            _persistentActions = new Queue<Action>(24);

        }

        /// <summary>
        /// Enqueue action that will be not removed on <see cref="Clear"/>
        /// </summary>
        /// <param name="action">Action to execute on the main thread.</param>
        public void EnqueuePersistent(Action action)
        {
            lock (_persistentActions)
            {
                _persistentActions.Enqueue(action);
            }
        }

        public bool DequeuePersistent(out Action result)
        {
            lock (_persistentActions)
            {
                if (_persistentActions.Count > 0)
                {
                    result = _persistentActions.Dequeue();
                    return true;
                }
            }

            result = null;
            return false;
        }

        /// <summary>
        /// Delayed action to be performed on the main thread.
        /// <see cref="TickDelayedActions"/> have to be ticked from the game loop to make it work.
        /// </summary>
        /// <param name="action">Action to execute on the main thread.</param>
        public void Enqueue(DelayedAction action)
        {
            lock (_delayedActions)
            {
                for (int i = 0; i < _delayedActions.Length; i++)
                {
                    if (_delayedActions[i] == null)
                    {
                        _delayedActions[i] = action;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Tick this function from the main thread to keep track on when delayed actions should be performed.
        /// </summary>
        /// <param name="time">Time from the game loop.</param>
        public void TickDelayedActions(float time)
        {
            lock (_delayedActions)
            {
                for (int i = 0; i < _delayedActions.Length; i++)
                {
                    var act = _delayedActions[i];
                    if (act != null)
                    {
                        if ((act.TimeToGo -= time) <= 0)
                        {
                            try
                            {
                                act.Action?.Invoke();
                            }

                            finally
                            {
                                _delayedActions[i] = null;
                            }
                        }
                    }
                }
            }
        }

        public void Enqueue(Action action)
        {
            lock (_threadedActions)
            {
                _threadedActions.Enqueue(action);
            }
        }

        public bool Dequeue(out Action result)
        {
            lock (_threadedActions)
            {
                if (_threadedActions.Count > 0)
                {
                    result = _threadedActions.Dequeue();
                    return true;
                }
            }

            result = null;
            return false;
        }

        public void Enqueue(IEnumerator coroutine)
        {
            lock (_coroutines)
            {
                _coroutines.Enqueue(coroutine);
            }
        }

        public bool Dequeue(out IEnumerator result)
        {
            lock (_coroutines)
            {
                if (_coroutines.Count > 0)
                {
                    result = _coroutines.Dequeue();
                    return true;
                }
            }

            result = null;
            return false;
        }

        /// <summary>
        /// Clear all non-persistent actions, delayed actions and coroutines.
        /// </summary>
        public void Clear()
        {
            lock (_threadedActions)
            {
                _threadedActions.Clear();
            }

            lock (_coroutines)
            {
                _coroutines.Clear();
            }

            lock (_delayedActions)
            {
                _delayedActions.Clear();
            }
        }
    }
}
