using System;

namespace Chain_Of_Reasponsability_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            car C = new car();
            FirstHandle f1 = new FirstHandle();
            SecondHandle f2 = new SecondHandle();
            ThirdHandle f3 = new ThirdHandle();
            f1.SetNext(f2);
            f2.SetNext(f3);

            f1.HandleRequest(C);
            Console.ReadLine();
        }
    }

}
