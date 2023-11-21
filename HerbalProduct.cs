using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12AssignmentPart2
{
    public class HerbalProduct : Product
    {
        string herbsUsed;
        DateTime mfDate;
        DateTime expDate;
        public HerbalProduct()
        {
            Console.WriteLine("Herbal class Constructor");
        }

        public override void setInfo()
        {
            base.setInfo();
            Console.WriteLine("Enter herbsUsed");
            herbsUsed = Console.ReadLine();
            mfDate=DateTime.Now;
            expDate=DateTime.Now.AddMonths(23);
            
        }
        public override void Show()
        {
            Console.WriteLine("Herbs Used:\t" + herbsUsed);
            Console.WriteLine("Product mfg Date:\t"+mfDate.ToShortDateString());
            Console.WriteLine("Product Exp Date:\t" + expDate.ToShortDateString());

        }
    }
}
