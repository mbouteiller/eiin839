using System;
using System.Net.Http;

namespace TD3
{
    class Request
    {

        public string getAllStations(HttpClient client) 
        {
            try
            {
                var response = client.GetStringAsync("https://api.jcdecaux.com/vls/v1/stations?&apiKey=1e38916a2fba5f218ec0c8f0053dac5aa8cd5567");
                response.Wait();

                return response.Result;
            }
            catch
            {
                Console.WriteLine("Error while sending request.");
                return "Error while sending request.";
            }
        }

        public string getContracts(HttpClient client)
        {
            try
            {
                var response = client.GetStringAsync("https://api.jcdecaux.com/vls/v1/contracts/?apiKey=1e38916a2fba5f218ec0c8f0053dac5aa8cd5567");
                response.Wait();

                return response.Result;
            }
            catch
            {
                Console.WriteLine("Error while sending request.");
                return "Error while sending request.";
            }
        }

        public string getStations(HttpClient client, string name)
        {
            var response = client.GetStringAsync("https://api.jcdecaux.com/vls/v1/stations?contract=" + name + "&apiKey=1e38916a2fba5f218ec0c8f0053dac5aa8cd5567");
            response.Wait();

            return response.Result;

        }

        public string getStation(HttpClient client, string name, string number)
        {
            var response = client.GetStringAsync("https://api.jcdecaux.com/vls/v1/stations/" + number + "?contract=" + name + "&apiKey=1e38916a2fba5f218ec0c8f0053dac5aa8cd5567");
            response.Wait();

            return response.Result;

        }
    }
}