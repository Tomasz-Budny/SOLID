using System;

namespace OC
{
    // Open Close principle - klasa powinna być zamknięta na modyfikacje i otwarta na rozszerzenia
    public class DataPersistence
    {
        private Data data;
        private IDataSaver _dataSaver;

        public DataPersistence(Data data, IDataSaver dataSaver)
        {
            this.data = data;
            _dataSaver = dataSaver;
        }

        // dzięki tej metodzie nie ma potrzeby modyfikować klasy ponieważ jak chcemy zmodyfikować Save wstrzykujemy inną klasę implementującą intrfejs IDataSaver
        public void Save()
        {
            _dataSaver.Save(data); // wydzielająć implemenetacje do pewnej abstrackcji otwieramy klasę na rozszerzenia
        }
    }

    public class Data
    {
        public string SomeData { get; set; }
    }

    public interface IDataSaver
    {
        void Save(Data data);
    }

    public class ExcelSaver : IDataSaver
    {
        public void Save(Data data)
        {
            Console.WriteLine($"saving data: {data.SomeData} as excel file");
        }
    }
}