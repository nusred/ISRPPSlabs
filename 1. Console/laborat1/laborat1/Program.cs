using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat1
{
    class Date//вложенный класс
    {
        private int year = 0;//защищённый атрибут
        private byte day = 0;
        private byte month = 0;

        public int Year//атрибут доступа
        {
            set
            {
                if (value < 1 || value > 2022)
                {
                    throw new ArgumentOutOfRangeException();
                }
                year = value; //value - значение, которое стоит в операторе присваивания
            }
            get { return year; }
        }
        public byte Day
        {
            set
            {
                if (value <= 0 || value > 31)
                    throw new ArgumentOutOfRangeException();
                day = value;
            }
            get { return day; }
        }
        public byte Month
        {
            set
            {
                if (value <= 0 || value > 12)
                    throw new ArgumentOutOfRangeException();
                month = value;
            }
            get { return month; }
        }

        public void print()
        {
            Console.WriteLine($"{day}.{month}.{year}");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Int size = {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"Int sizeof = {sizeof(int)}");
            Console.WriteLine($"Uint size = {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"Uint sizeof = {sizeof(uint)}");

            Console.WriteLine($"Byte size = {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"Short size = {short.MinValue} to {short.MaxValue}");

            Console.WriteLine($"Double size = {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"Float size = {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"Decimal size = {decimal.MinValue} to {decimal.MaxValue}");

            Console.WriteLine("");
            float[] arr = new float[3] { 2.7f, 5.1f, 8.2f };//чтобы комп понял, что это не double, а float (по умолчанию идет double)
            foreach (float f in arr)
            {
                Console.WriteLine("{0} ", f);
            }

            Console.WriteLine("");
            Date date = new Date();
            for (; ; )
            {
                Console.WriteLine("Input year");
                try
                {
                    date.Year = Convert.ToInt32(Console.ReadLine());//строковое конвертируем в целочисленный тип
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format, try again");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of Range, try again");
                }
            }

            for (; ; )
            {
                Console.WriteLine("Input month");
                try
                {
                    date.Month = Convert.ToByte(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Out of Range, try again");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of Range, try again");
                }
            }

            for (; ; )
            {
                Console.WriteLine("Input day");
                try
                {
                    date.Day = Convert.ToByte(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Out of Range, try again");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of Range, try again");
                }
            }

            date.print();
        }
    }

}
