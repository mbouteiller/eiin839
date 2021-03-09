using System;

namespace TD3
{
    class Station
    {
        public int number { get; set; }
        public string contractName { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string status { get; set; }
        public Position position { get; set; }

        public override string ToString() 
        {
            string description = "";

            description += number.ToString() + " "
                + contractName + " "
                + name + " "
                + address + " "
                + status + " "
                + position.ToString();

            return description;
        }

    }
}
