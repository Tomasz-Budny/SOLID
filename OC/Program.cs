using System;

namespace OC
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new() { SomeData = "data #1" };

            DataPersistence persistence = new DataPersistence(data, new ExcelSaver());
            persistence.Save();
        }
    }
}