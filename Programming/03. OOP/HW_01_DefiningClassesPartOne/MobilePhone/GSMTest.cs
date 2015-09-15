using System;

namespace MobilePhone
{
    class GSMTest
    {
        static void Main()
        {
            GSM[] test = new GSM[4];

            Display testDisplay = new Display(11, 8);
            Battery testBattery = new Battery(BatteryType.NiCd, 2, 3289);

            test[0] = new GSM("Desire HD", "HTC", "Me");
            test[1] = new GSM("IPhone3", "Apple", "Stefoto", 600);
            test[2] = new GSM("Lumia", "Nokia", "Vel", 700, testBattery);
            test[3] = new GSM("One X", "HTC", "You", 1000, testBattery, testDisplay);

            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            Console.WriteLine("----IPhone4S----");
            Console.WriteLine(GSM.IPhone4S.Model);
            Console.WriteLine(GSM.IPhone4S.Manufacturer);
        }
    }
}