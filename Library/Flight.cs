using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public enum National
    {
        BuenosAires,
        SantaRosa,
        Bariloche,
        Corrientes,
        Córdoba,
        Jujuy,
        Mendoza,
        Neuquén,
        Posadas,
        Iguazú,
        Salta,
        SantiagoDelEstero,
        Trelew,
        Tucumán,
        PuertoMadryn,
        Ushuaia,
    }

    public enum International
    {        
        Recife,        
        Rome,        
        Acapulco,        
        Miami,
    }

    public class Flight
    {
        //******************************************************

        private Airplane airplane;
        private string origin;
        private string destination;
        private SortedDictionary<int, Passenger> tourist;
        private SortedDictionary<int, Passenger> premium;
        private List<Luggage> cargo;
        private float price;
        private float premiumPrice;
        private string flightDuration;
        private string flightStart;
        private string flightEnd;
        private float flightEarned;
        private bool isNational;

        //******************************************************

        public Flight(Airplane airplane, string origin, string destination, SortedDictionary<int, Passenger> tourist, SortedDictionary<int, Passenger> premium, List<Luggage> cargo,
                    float price, string flightDuration, string flightStart, string flightEnd)
        {
            this.airplane = airplane;
            this.origin = origin;
            this.destination = destination;
            this.tourist = tourist;
            this.premium = premium;
            this.price = price;
            this.cargo = cargo;
            this.premiumPrice = CalculatePremiumPrice(price);
            this.flightDuration = flightDuration;
            this.flightStart = flightStart;
            this.flightEnd = flightEnd;
            this.flightEarned = Earned(PassengersPremium, PremiumPrice, PassengersTourist, Price);
        }

        //******************************************************

        public override string ToString()
        {

            string wifi = (this.Airplane.HasWifi) ? "Yes" : "No";
            string food = (this.Airplane.HasFood) ? "Yes" : "No";

            StringBuilder daFlight = new StringBuilder();

            daFlight.Append(this.Tag + "|");
            daFlight.Append(this.origin + "|");
            daFlight.Append(this.destination + "|");
            daFlight.Append(this.AmountPassengers.ToString() + "|");
            daFlight.Append((this.airplane.SeatsPremium - this.PassengersPremium).ToString() + "|");
            daFlight.Append(this.PremiumPrice.ToString("c2") + "|");
            daFlight.Append((this.airplane.SeatsTourist - this.PassengersTourist).ToString() + "|");
            daFlight.Append(this.price.ToString("c2") + "|");
            daFlight.Append(wifi + "|");
            daFlight.Append(food + "|");

            return daFlight.ToString();
        }

        //******************************************************


        public string Origin { get => origin;}
        public string Destination { get => destination;}        
        public float Price { get => price;}
        public int AmountPassengers { get => premium.Count+tourist.Count; }
        public string FlightDuration { get => flightDuration;}
        public string FlightStart { get => flightStart;}
        public string FlightEnd { get => flightEnd;}        
        public float PremiumPrice { get => premiumPrice; }
        public int PassengersTourist { get => tourist.Count;}
        public int PassengersPremium { get => premium.Count;}
        public SortedDictionary<int, Passenger> Tourist { get => tourist; set => tourist = value; }
        public SortedDictionary<int, Passenger> Premium { get => premium; set => premium = value; }
        public float FlightEarned { get => Earned(PassengersPremium, PremiumPrice, PassengersTourist, Price); }
        public Airplane Airplane { get => airplane;}
        public string Tag { get => this.airplane.Tag; }
        public int Wcs { get => this.airplane.WCs1; }
        public int SeatsTotal { get => this.airplane.SeatsTotal; }
        public int MaxCargo { get => this.airplane.MaxCargo; }
        public int Cargo { get => this.cargo.Count; }
        public string HasWifi { get { if (this.airplane.HasWifi) { return "Yes"; } else { return "No";  } } }
        public string HasFood { get { if (this.airplane.HasFood) { return "Yes"; } else { return "No"; } } }

        public bool IsNational { get => isNational; set => isNational = value; }
        public List<Luggage> CargoLst { get => cargo; }
        

        private float CalculatePremiumPrice(float price)
        {
            return (price * 1.15f);
        }

        private float Earned(int premiumSeats, float premiumPrice, int touristSeats, float touristPrice)
        {
            return ((premiumPrice * 1.21f * premiumSeats) + (touristPrice * 1.21f * touristSeats));
        }
    }
}
