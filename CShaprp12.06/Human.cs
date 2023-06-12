using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprp12._06
{
    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"Фамилия: {LastName}, Имя: {FirstName}\n" +
                $"Дата рождения: {BirthDate.ToLongDateString()}";
        }
    }
    abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + 
                $"\nДолжность: {Position}, Зарплата: {Salary}";
        }
    }
    interface IWorker
    {
        bool IsWorking { get; }
        string Work();
    }
    interface IManager
    {
        List<IWorker> ListOfWorkers { get; set; }
        void Organize();
        void MakeBudget();
        void Control();
    }
    class Director : Employee, IManager
    {
        public List<IWorker> ListOfWorkers { get; set; }

        public void Control()
        {
            Console.WriteLine("Контролирует работу!");
        }

        public void MakeBudget()
        {
            Console.WriteLine("Формирую бюджет");
        }

        public void Organize()
        {
            Console.WriteLine("Организую работу!");
        }
    }
    class Seller : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking
        {
            get { return isWorking; }
        }

        public string Work()
        {
            return "Продаю товар";
        }
    }
    class Cashier : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking
        {
            get { return isWorking; }
        }

        public string Work()
        {
            return "Принимаю оплату за товар";
        }
    }
    class Storekeeper : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking
        {
            get { return isWorking; }
        }

        public string Work()
        {
            return "Произвожу учет товара";
        }
    }

}
