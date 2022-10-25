using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {
        public override float NoiseLevel => base.NoiseLevel * supression;

        private float supression;

        public GunSilencer(Gun gun, float supression) : base(gun)
        {
            this.supression = supression;
        }
    }
}