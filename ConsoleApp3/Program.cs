using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage hdd = new HDD(100, 480);
            Storage dvd = new DVD(9, 21);
            Storage flash = new Flash(16, 119);

            Storage[] storage = new Storage[] { hdd, dvd, flash };

            for(int i=0; i<3; i++)
            {
                storage[i].CopyData("Video", 980);
                storage[i].Info(20);
            }

            HDD hdd1 = new HDD(1000, 480);
            hdd.CopyData("Video", 980);
            hdd.Info(980);
            

            DVD dvd1 = new DVD(9, 21);
            hdd.CopyData("File", 4);
            hdd.Info(4);
         

            Flash flash1 = new Flash(16, 119);
            hdd.CopyData("Video", 1);
            hdd.Info(1);
          

            Console.ReadLine();
        }
    }
}
