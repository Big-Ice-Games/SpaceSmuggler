﻿using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
{
    /// <summary>
    /// <see cref="OreType"/>
    /// </summary>
    public sealed class Ore
    {
        public OreType OreType { get; set; }
        public int Quantity { get; set; }
    }
}
