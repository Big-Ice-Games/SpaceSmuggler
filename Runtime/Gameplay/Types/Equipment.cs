using System.Collections;
using System.Collections.Generic;
using BIG;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
{
    [Preserve]
    public sealed class Equipment : IEnumerable<ShipComponent>
    {
        [Preserve] public ShipComponentSlot Pilot1;
        [Preserve] public ShipComponentSlot Pilot2;
        [Preserve] public ShipComponentSlot Pilot3;
        [Preserve] public ShipComponentSlot Pilot4;

        [Preserve] public ShipComponentSlot Weapon1;
        [Preserve] public ShipComponentSlot Weapon2;
        [Preserve] public ShipComponentSlot Weapon3;
        [Preserve] public ShipComponentSlot Weapon4;

        [Preserve] public ShipComponentSlot Armor1;
        [Preserve] public ShipComponentSlot Armor2;
        [Preserve] public ShipComponentSlot Armor3;
        [Preserve] public ShipComponentSlot Armor4;

        [Preserve] public ShipComponentSlot Scanner;
        [Preserve] public ShipComponentSlot Shield;
        [Preserve] public ShipComponentSlot Engine;
        [Preserve] public ShipComponentSlot EnergyCore;

        [Preserve] public Equipment(){}

        [Preserve]
        public Equipment(int weaponSlots, int armorSlots, int pilotSlots)
        {
            Pilot1 = new ShipComponentSlot(pilotSlots > 0 ? ShipComponentType.Pilot : ShipComponentType.None);
            Pilot2 = new ShipComponentSlot(pilotSlots > 1 ? ShipComponentType.Pilot : ShipComponentType.None);
            Pilot3 = new ShipComponentSlot(pilotSlots > 2 ? ShipComponentType.Pilot : ShipComponentType.None);
            Pilot4 = new ShipComponentSlot(pilotSlots > 3 ? ShipComponentType.Pilot : ShipComponentType.None);

            Weapon1 = new ShipComponentSlot(weaponSlots > 0 ? ShipComponentType.Weapon : ShipComponentType.None);
            Weapon2 = new ShipComponentSlot(weaponSlots > 1 ? ShipComponentType.Weapon : ShipComponentType.None);
            Weapon3 = new ShipComponentSlot(weaponSlots > 2 ? ShipComponentType.Weapon : ShipComponentType.None);
            Weapon4 = new ShipComponentSlot(weaponSlots > 3 ? ShipComponentType.Weapon : ShipComponentType.None);

            Armor1 = new ShipComponentSlot(armorSlots > 0 ? ShipComponentType.Armor : ShipComponentType.None);
            Armor2 = new ShipComponentSlot(armorSlots > 1 ? ShipComponentType.Armor : ShipComponentType.None);
            Armor3 = new ShipComponentSlot(armorSlots > 2 ? ShipComponentType.Armor : ShipComponentType.None);
            Armor4 = new ShipComponentSlot(armorSlots > 3 ? ShipComponentType.Armor : ShipComponentType.None);

            Scanner = new ShipComponentSlot(ShipComponentType.Scanner);
            Shield = new ShipComponentSlot(ShipComponentType.Shield);
            Engine = new ShipComponentSlot(ShipComponentType.Engine);
            EnergyCore = new ShipComponentSlot(ShipComponentType.EnergyCore);
        }

        public List<Property> GetAllProperties()
        {
            List<Property> properties = new List<Property>();
            foreach (ShipComponent shipComponent in this)
            {
                foreach (Property property in shipComponent.Properties)
                {
                    var index = properties.IndexOf(property);
                    if (index == -1)
                    {
                        properties.Add(property);
                    }
                    else
                    {
                        properties[index].Value += property.Value;
                    }
                }
            }

            return properties;
        }

        public IEnumerator<ShipComponent> GetEnumerator()
        {
            if (Pilot1.SlotType != ShipComponentType.None && Pilot1.Component != null)
                yield return Pilot1.Component;
            if (Pilot2.SlotType != ShipComponentType.None && Pilot2.Component != null)
                yield return Pilot2.Component;
            if (Pilot3.SlotType != ShipComponentType.None && Pilot3.Component != null)
                yield return Pilot3.Component;
            if (Pilot4.SlotType != ShipComponentType.None && Pilot4.Component != null)
                yield return Pilot4.Component;

            if (Weapon1.SlotType != ShipComponentType.None && Weapon1.Component != null)
                yield return Weapon1.Component;
            if (Weapon2.SlotType != ShipComponentType.None && Weapon2.Component != null)
                yield return Weapon2.Component;
            if (Weapon3.SlotType != ShipComponentType.None && Weapon3.Component != null)
                yield return Weapon3.Component;
            if (Weapon4.SlotType != ShipComponentType.None && Weapon4.Component != null)
                yield return Weapon4.Component;

            if (Armor1.SlotType != ShipComponentType.None && Armor1.Component != null)
                yield return Armor1.Component;
            if (Armor2.SlotType != ShipComponentType.None && Armor2.Component != null)
                yield return Armor2.Component;
            if (Armor3.SlotType != ShipComponentType.None && Armor3.Component != null)
                yield return Armor3.Component;
            if (Armor4.SlotType != ShipComponentType.None && Armor4.Component != null)
                yield return Armor4.Component;

            if(Scanner.SlotType != ShipComponentType.None && Scanner.Component != null)
                yield return Scanner.Component;
            if(Shield.SlotType != ShipComponentType.None && Shield.Component != null)
                yield return Shield.Component;
            if(Engine.SlotType != ShipComponentType.None && Engine.Component != null)
                yield return Engine.Component;
            if(EnergyCore.SlotType != ShipComponentType.None && EnergyCore.Component != null)
                yield return EnergyCore.Component;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
