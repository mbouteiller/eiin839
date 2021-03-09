using System;
using System.Collections.Generic;
using System.Text;

namespace TD3
{
    class Utils
    {
        public void displayStations(Station[] stations)
        {
            foreach (Station station in stations)
            {
                Console.WriteLine(station.ToString());
            }
        }

        public void displayStation(Station station)
        {
            Console.WriteLine(station.ToString());
        }

        public void displayContracts(Contract[] contracts)
        {
            foreach (Contract contract in contracts)
            {
                Console.WriteLine(contract.ToString());
            }
        }
    }
}
