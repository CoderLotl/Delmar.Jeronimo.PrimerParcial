using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Lists
    {
        // THIS IS THE PLACE WHERE ALL THE LISTS RESIDE.

        //******************************************************
        private static List<Passenger> passengers;
        private static List<Passenger> clients;
        private static List<Airplane> airplanes;
        private static List<Airplane> airplanesInTheAir;
        private static List<Flight> flights;
        private static List<Flight> history;
        private static float[] earnedTotal;
        private static float[] earnedNational;
        private static float[] earnedInternational;
        //******************************************************

        public static List<Passenger> Passengers { get => passengers; set => passengers = value; }
        public static List<Airplane> Airplanes { get => airplanes; set => airplanes = value; }
        public static List<Airplane> AirplanesInTheAir { get => airplanesInTheAir; set => airplanesInTheAir = value; }
        public static List<Flight> Flights { get => flights; set => flights = value; }
        public static List<Flight> History { get => history; set => history = value; }
        public static float[] EarnedTotal { get => earnedTotal; set => earnedTotal = value; }
        public static float[] EarnedNational { get => earnedNational; set => earnedNational = value; }
        public static float[] EarnedInternational { get => earnedInternational; set => earnedInternational = value; }
        public static List<Passenger> Clients { get => clients; set => clients = value; }

        public static void BuildLists()
        {
            passengers = Passenger.CreatePassengersList();

            clients = Passenger.CreatePassengersList();

            airplanes = Airplane.CreateAirplanesList();
            airplanes = Fleet.GenerateFleet();

            airplanesInTheAir = Airplane.CreateAirplanesList();

            flights = Flight.CreateFlightList();

            history = Flight.CreateFlightList();

            earnedTotal = new float[1];
            earnedTotal[0] = 0;

            earnedNational = new float[1];
            earnedNational[0] = 0;

            earnedInternational = new float[1];
            earnedInternational[0] = 0;
            
        }

    }
}
