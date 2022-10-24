using System;

namespace LSP
{
    // Liskov substitution principle - (zasada podstawienia Liskov) - metody które
    // używają wskaźników lub refenrencji do klas bazowych muszą być w stanie używać również obiektów
    // klas dziedziczących po klasach bazowych bez znajomości tych obiektów.
    
    // Najbardziej popularny przykład
    public abstract class Duck
    {
        public abstract void Swim();
        public abstract void Quack();
    }

    public class RegularDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("regular duck swim");
        }

        public override void Quack()
        {
            Console.WriteLine("regular duck quack");
        }
    }

    public class ElectricDuck : Duck
    {
        public bool IsTurnOn = false;

        public void TurnOnDuck()
        {
            IsTurnOn = true;
        }

        public void TurnOffDuck()
        {
            IsTurnOn = false;
        }
        
        public override void Swim()
        {
            if (!IsTurnOn)
                return;
            Console.WriteLine("electric duck swim");
        }

        public override void Quack()
        {
            Console.WriteLine("electric duck quack");
        }
    }
}