using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Models;
namespace A_GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailBL ebl = Utilities.ConfigEmailDependencies("Mock");
            List<Email> list = ebl.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine(  );
            }

            Console.ReadLine();
        }
    }
}
