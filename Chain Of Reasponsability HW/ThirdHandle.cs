using System;

namespace Chain_Of_Reasponsability_HW
{
    public class ThirdHandle : BaseHandler
    {
        public override void HandleRequest(car C)
        {
            int x =  new Random().Next(1, 11);
            if (x >= 6)
            {
                Console.WriteLine("Third check pessed");
                C.Fixed = true;

            }
            else
            {
                if (Next != null)
                {
                    Next.HandleRequest(C);
                }
                else
                {
                    Console.WriteLine("Fix Failed");
                }
            }
        }
    }

}
