using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Destination
    {
        private string destination;
        private int flights;
        private int passengers;
        private float earned;

        public Destination(string destination, int flights, float earned, int passengers)
        {
            this.destination = destination;
            this.flights = flights;
            this.passengers = passengers;
            this.earned = earned;
        }

        public string DestinationP { get => destination; set => destination = value; }
        public int Flights { get => flights; set => flights = value; }
        public float Earned { get => earned; set => earned = value; }
        public int Passengers { get => passengers; set => passengers = value; }

        public override string ToString()
        {
            StringBuilder daDestination = new StringBuilder();

            daDestination.Append(destination + "|");
            daDestination.Append(flights + "|");
            daDestination.Append(passengers.ToString() + "|");
            daDestination.Append(earned.ToString() + "|");

            return daDestination.ToString();
        }

        public static List<Destination> PopulateDestinations()
        {
            List <Destination> destinations = new List<Destination>();

            foreach (var item in Enum.GetValues(typeof(National)))
            {
                string str = "";

                switch (item.ToString())
                {
                    case "BuenosAires":
                        str = "Buenos Aires";
                        break;
                    case "SantaRosa":
                        str = "Santa Rosa";
                        break;
                    case "SantiagoDelEstero":
                        str = "Santiago Del Estero";
                        break;
                    case "PuertoMadryn":
                        str = "Puerto Madryn";
                        break;
                    default:
                        str = item.ToString();
                        break;
                }

                Destination destination = new Destination(str, 0, 0, 0);
                destinations.Add(destination);
            }

            //-------------

            foreach (var item in Enum.GetValues(typeof(International)))
            {
                string str = "";

                switch (item.ToString())
                {
                    case "Recife":
                        str = "Recife (Brasil)";
                        break;
                    case "Rome":
                        str = "Rome (Italy)";
                        break;
                    case "Acapulco":
                        str = "Acapulco (Mexico)";
                        break;
                    case "Miami":
                        str = "Miami (USA)";
                        break;
                }

                Destination destination = new Destination(str, 0, 0, 0);
                destinations.Add(destination);
            }

            return destinations;
        }
    }
}
