using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bai2_buoi2
{
    internal class Program
    {
        static void Main(string[] args)           
        {
            Console.WriteLine("nhap vao mot chuoi: ");
            string StringIn;
            string StringOut=string.Empty;
            StringIn= Console.ReadLine(); 
            StringIn.ToList().ForEach(x=>StringOut=x+StringOut);  
            Console.WriteLine(StringOut);
            Console.ReadKey();
        }
    }
}
