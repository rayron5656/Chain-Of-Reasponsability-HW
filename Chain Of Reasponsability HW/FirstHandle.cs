using System;

namespace Chain_Of_Reasponsability_HW
{
    public class FirstHandle : BaseHandler
    {
        public override void HandleRequest(car C)
        {
            int x = new Random().Next(1, 11);
            if (x >= 6)
            {
                Console.WriteLine("First check pessed");
                C.Fixed = true;

            }
            else
            {
                if (Next != null)
                {
                    Next.HandleRequest(C);
                }
            }
        }
    }

}
