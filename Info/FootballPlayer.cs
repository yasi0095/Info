using System;

namespace FootballPLayer
{
    public class FootballPlayer
    {
        // Instance field
        private int id;
        private string name;
        private int price;
        private int shirtNumber;

        //Property
        public int Id
        {
            get => id;
            set
            {
                if (value < 0) throw new ArgumentException("invalid number! Try again");
                {
                    id = value;
                }
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 3) throw new ArgumentException("Name has to be at least 4 letters");
                name = value;
            }
        }
        public int Price
        {
            get => price;
            set
            {
                if (value < 0) throw new ArgumentException("Price need to be higher than 0");
                price = value;
            }
        }
        public int ShirtNumber
        {
            get => shirtNumber;
            set
            {
                if (1 < value && value > 99) throw new ArgumentException("Shirt number should be between 1 - 99");
                shirtNumber = value;
            }
        }

        // Constructor
        public FootballPlayer(int id, string name, int price, int shirtNumber)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.shirtNumber = shirtNumber; 
        }

        public FootballPlayer()
        {
                
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Price)}: {Price}, {nameof(ShirtNumber)}: {ShirtNumber}";
        }

    }
}
