using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprp12._06
{
    internal class Program
    {
        public interface IResearcher
        {
            void Investigate();
            void Invent();
            string Str { get; set; }
        }
        static void Main(string[] args)
        {
            /*
            Дан двумерный массив размерностью 5×5, 
            заполненный случайными числами из диапазона от –100 до 100.
            Определить сумму элементов массива, расположенных
            между минимальным и максимальным элементами
            */
            /*int[,] arr = new int[5, 5];
            Random random= new Random();
            int max_j = 0, max_i = 0, min_j = 0, min_i = 0 , sum = 0;
            // инициализация массива
            for (int i =0; i< 5; i++)
            {              
                for (int j = 0; j < 5; j++)
                {
                    arr[i,j] = random.Next(-100,100);
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            int max = arr[0,0], min = arr[0,0];
            // поиск положения максимального и минимального элементов
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i,j];
                        max_i = i;
                        max_j = j;
                    }
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                        min_i = i;
                        min_j = j;
                    }
                }               
            }
            //определение кто стоит раньше (макс или мин)
            int temp;
            if (max_i < min_i)
            {
                temp = min_i;
                min_i = max_i;
                max_i = temp;
            }
            if (max_j < min_j)
            { 
                temp = min_j;
                min_j = max_j;
                max_j = temp;
            }

            // подсчет суммы в выбранном диапазоне
            int k, t;
            for (int i = min_i; i <= max_i; i++)
            {
                if (i == min_i)
                {
                    k = min_j;
                    t = 4;
                }
                else if (i == max_i)
                {
                    k = 0;
                    t = max_j;
                }
                else
                {
                    k = 0;
                    t = 4;
                }
                for (int j = k;j <= t; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum);*/

            /*Director director = new Director
            {
                LastName = "Ivanov",
                FirstName = "Ivan",
                BirthDate = new DateTime(1999, 2, 15),
                Position = "Директор",
                Salary = 120000
            };
            IWorker seller = new Seller
            {
                LastName = "Petrov",
                FirstName = "Petr",
                BirthDate = new DateTime(2002, 6, 18),
                Position = "Продавец",
                Salary = 60000
            };
            
            if (seller is Employee)
                Console.WriteLine($"Зарплата продавца: {(seller as Employee).Salary}");

            director.ListOfWorkers = new List<IWorker>
            {
                seller,
                new Cashier
                {
                    LastName = "Lenova",
                FirstName = "Lena",
                BirthDate = new DateTime(2003,11, 11),
                Position = "Кассир",
                Salary = 47000
                },
                new Storekeeper
                {
                    LastName = "Sidorov",
                FirstName = "Sidr",
                BirthDate = new DateTime(1995, 12, 30),
                Position = "Кладовщик",
                Salary = 55000
                }
            };
            Console.WriteLine(director);
            director.Control();

            foreach (IWorker item in director.ListOfWorkers)
            {
                Console.WriteLine(item);
                if (item.IsWorking) Console.WriteLine(item.Work());
            }*/

            //тип_данных this[тип_аргумента] { get; set; }

            Shop laptops = new Shop(3);
            laptops[0] = new Laptop { Vendor = "Lenovo", Price = 39000 };
            laptops[1] = new Laptop { Vendor = "HP", Price = 45999 };
            laptops[2] = new Laptop { Vendor = "Acer", Price = 54999 };

            try
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    Console.WriteLine(laptops[i]);
                }
                Console.WriteLine();
                Console.WriteLine($"Производитель Acer: {laptops["Acer"]}");
                Console.WriteLine($"Стоимость 45990: {laptops[45990.0]}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            /*MultArray multArray = new MultArray(2, 3);
            for (int i = 0; i < multArray.Rows; i++)
            {
                for (int j = 0; j < multArray.Cols; j++)
                {
                    multArray[i, j] = i + j;
                    Console.Write(multArray[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            Console.ReadKey();

        }
    }
}
