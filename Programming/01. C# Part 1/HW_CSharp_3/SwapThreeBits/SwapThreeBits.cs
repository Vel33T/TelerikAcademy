using System;

class SwapThreeBits
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        string str = Console.ReadLine();
       
        uint number = uint.Parse(str);
        Console.WriteLine("{0} | The number in binary before the swapping",Convert.ToString(number, 2).PadLeft(32, '0'));
        
        uint mask = 7;                                      //111 in binary
        uint firstBits = ((mask << 3) & number) >> 3;       //getting the bits from possitions 3,4,5
        uint secondBits = ((mask << 24) & number) >> 24;    //getting the bits from possitions 24,25,26

        number = (~(mask << 3)) & number;                   //Nullifying the bits at possitions 3,4,5
        number = (~(mask << 24)) & number;                  //Nullifying the bits at possitions 24,25,26

        number = (secondBits << 3) | number;                //Putting bits 24,25,26 at possition 3,4,5  
        number = (firstBits << 24) | number;                //Putting bits 3,4,5 at possition 24,25,263

        Console.WriteLine("{0} | The number in binary after the swapping",Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The new number is : {0}",number);
    }
}

