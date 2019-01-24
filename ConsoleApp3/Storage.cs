using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Storage
    {
       public const int GbOnMb = 8000;
        private int _Memory;
        private int _speed;
        private int _time;

        public string Name { get; set; }
        public string Model { get; set; }

        
        public int Memory
        {
            get
            {
                Console.WriteLine("Объем = ");
                    return _Memory;
            }
            set
            {
                _Memory = value;
            }
        }

        public int Speed
        {
            get
            {
                Console.WriteLine("Скорость = ");
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }





        public void CopyData(string file, int getMemory)
        {
            Console.WriteLine(file);
            Console.WriteLine("Память носителя = " + _Memory);
            Console.WriteLine("Память файл = " + getMemory);
            _time = (getMemory * GbOnMb) / _speed;
            Console.WriteLine("Время затраченное = " + _time + " сек");
        }
        public void Info(int Memory)
        {
            _Memory = _Memory - Memory;
            Console.WriteLine("Свободной памяти = " + _Memory);
        }
    }
}
