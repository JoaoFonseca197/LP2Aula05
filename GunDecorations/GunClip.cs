using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunClip : GunDecorator
    {
        public override int AmmoCapacity =>
        base.AmmoCapacity + additionalAmmo;
        private int additionalAmmo;
        public GunClip(Gun gun, int additionalAmmo) : base(gun)
        {
            this.additionalAmmo= additionalAmmo;
        }
    }
}