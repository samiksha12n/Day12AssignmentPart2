using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12AssignmentPart2
{
    public class Product
    {
        int pid;
        string pname;
        double pprice;
        public Product() 
        {
            Console.WriteLine("Product Constructor!!!");
        }
        public virtual void setInfo()
        {
            Console.WriteLine("Enter Id");
            pid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            pname=Console.ReadLine();
            Console.WriteLine("Enter Price");
            pprice=double.Parse(Console.ReadLine());
        }
        public virtual void Show()
        {
            Console.WriteLine("Product Id:\t"+pid);
            Console.WriteLine("Product Name:\t" + pname);
            Console.WriteLine("Product Price:\t" + pprice);
        }
    }
}
