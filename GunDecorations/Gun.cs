using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public abstract class Gun
    {
        public abstract int AmmoCapacity{get;}
        public abstract float NoiseLevel{get;}

        public virtual void Fire()
        {
            Console.WriteLine(AmmoCapacity+" "+NoiseLevel);
            Console.WriteLine($"Ammo capacity: {AmmoCapacity}");
            Console.WriteLine($"Noise Level: {NoiseLevel}");
        }
    }
}