using System;

namespace GunDecorations
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun mGun = new MachineGun();
            Gun mGunWithClip = new GunClip(mGun,10);
            Gun mGunWithClipAndSlencer = new GunSilencer(mGunWithClip, 0.5f);
            Gun sGun = new ShotGun();
            

            Console.WriteLine("== Machine Gun ==");
            mGun.Fire();
            Console.WriteLine("== Machine Gun ==");
            sGun.Fire();
            Console.WriteLine("== Machine Gun With Clip ==");
            mGunWithClip.Fire();
            Console.WriteLine("== Machine Gun With Clip and Silencer ==");
            mGunWithClipAndSlencer .Fire();
        }
    }
}
