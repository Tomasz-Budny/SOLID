using System;
using System.Collections.Generic;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricDuck electric = new ElectricDuck();
            RegularDuck regular = new RegularDuck();
            
            List<Duck> ducks = new List<Duck>();
            ducks.Add(electric);
            ducks.Add(regular);

            // elektryczna kaczka nie popłynie ponieważ nie jest włączona 
            // abstrakcja taka narusza zasadę podstawienia Liskov, należy ją zmienić
            foreach (var duck in ducks)
            {
                duck.Swim();
            }
        }
    }
}