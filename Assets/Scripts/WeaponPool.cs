using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace SpacePatterns
{
    internal sealed class WeaponPool 
    {
        private Weapon _weapon;
        private Transform _containerTransform;
        private List<Weapon> _weaponPool;
        private int _capacityPool;

        public WeaponPool(Weapon weapon, int capacityPool, Transform containerTransform )
        {
            _weapon = weapon;
            _capacityPool = capacityPool;
            _containerTransform = containerTransform;
            CreatePool(_capacityPool);
        }

        private void CreatePool(int count)
        {
            _weaponPool = new List<Weapon>();
            for (int i = 0; i < count; i++)
            {
                CreatedObject();
            }
        }

        private Weapon CreatedObject()
        {
            var createdObject = Object.Instantiate(_weapon, _containerTransform);
            createdObject.gameObject.SetActive(false);
           _weaponPool.Add(createdObject);
            return createdObject;
        }

        public bool HasFreeElement(out Weapon element)
        {
            foreach (var weapon in _weaponPool)
            {
                if(!weapon.gameObject.activeInHierarchy)
                {
                    element = weapon; 
                    weapon.gameObject.SetActive(true);
                    return true;
                }
            }
            element = null;
            return false;
        }

        public Weapon GetFreeElement()
        {
            if (HasFreeElement(out Weapon element))
                return element;
            else
                throw new Exception("No more free objects");
        }
    }
}