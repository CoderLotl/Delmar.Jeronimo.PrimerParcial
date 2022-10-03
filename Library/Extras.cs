using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public static class Extras
    {
        public static void RandomClientsGenerator(int amount, List<Passenger> newClients,List<Passenger> currentClients)
        {
            int i;
            int j = amount;           

            for (i = 0; i < j; i++)
            {
                string name = "";
                string lastName = "";
                string dni = "";
                int age = 0;
                string gender = "";
                Random randomNum = new Random();

                int num = randomNum.Next(0, 3);

                gender = AsignGender(num);

                string[] names = new string[2];
                AsignName(num, names);
                name = names[0];
                lastName = names[1];

                num = randomNum.Next(18, 120);
                age = num;
                num = randomNum.Next(10000, 50000);
                dni = num.ToString();

                Passenger passenger = new Passenger(name, lastName, gender, dni, age);
                passenger.OnFly = false;

                int foundDni = CheckDni(newClients, currentClients, passenger);

                if (foundDni == 0)
                {
                    newClients.Add(passenger);
                }
            }            
        }

        //***********************************************

        private static string AsignGender(int number)
        {
            string gender = "";
            switch (number)
            {
                case 0:
                    gender = "Non-binary";
                    break;
                case 1:
                    gender = "Male";
                    break;
                case 2:
                    gender = "Female";
                    break;
            }
            return gender;
        }

        //***********************************************

        private static string[] AsignName(int num, string[] names)
        {
            Random randomNum = new Random();

            if (num == 2 || num == 0)
            {
                num = randomNum.Next(0, 12);
                string[] nameRdm = { "Adriana", "Ariadna", "Aleatha", "Daria", "Chloe", "Fiora", "Jasmine", "Loraine", "Moira", "Paula", "Rose", "Susan" };
                names[0] = nameRdm[num];
                num = randomNum.Next(0, 9);
                string[] lastNameRdm = { "Steinman", "Ramirez", "Woods", "Smith", "Cohen", "Ryan", "Miller", "Brown", "Johnson" };
                names[1] = lastNameRdm[num];
            }
            if (num == 1 || num == 0)
            {
                num = randomNum.Next(0, 12);
                string[] nameRdm = { "John", "David", "Arthur", "Garen", "Andrew", "Jack", "Frank", "Sander", "Luke", "Charles", "Mathew", "Alexander" };
                names[0] = nameRdm[num];
                num = randomNum.Next(0, 9);
                string[] lastNameRdm = { "Steinman", "Ramirez", "Woods", "Smith", "Cohen", "Ryan", "Miller", "Brown", "Johnson" };
                names[1] = lastNameRdm[num];
            }
            return names;
        }

        //***********************************************

        private static int CheckDni(List<Passenger> newClients, List<Passenger> currentClients , Passenger passenger)
        {
            int foundDni = 0;
            int t;

            for (t = 0; t < newClients.Count; t++)
            {
                if (newClients[t].Dni == passenger.Dni)
                {
                    foundDni = 1;
                    break;
                }
            }
            for (t = 0; t < currentClients.Count; t++)
            {
                if (currentClients[t].Dni == passenger.Dni)
                {
                    foundDni = 1;
                    break;
                }
            }

            return foundDni;
        }

        //***********************************************
        //*******************************************
        //***********************************************

        public static void HardcodingFlights(List<Passenger> passengers,List<Flight> history, float[] earnedTotal, float[] earnedNational, float[] earnedInternational,
                                                List<Destination> destinations)
        {
            Random dice = new Random();
            int flights = dice.Next(10, 21); // SETTING THE AMOUNT OF FLIGHTS TO CREATE
            int clients = dice.Next(20, 51); // SETTING THE AMOUNT OF PASSENGERS TO CREATE
            int nationalLocations = Enum.GetValues(typeof(National)).Length; // CHECKING THE AMOUNT OF NATIONAL LOCATIONS
            int internationalLocations = Enum.GetValues(typeof(International)).Length; // CHECKINGF THE AMOUNT OF INTERNATIONAL LOCATIONS

            RandomClientsGenerator(clients, passengers, passengers); // CREATING RANDOM CLIENT-PASSENGERS THAT WILL EXIST AFTER THIS.

            for (int i = 0; i < flights; i++) // CREATING FLIGHTS
            {
                Airplane airplane = Fleet.airplanes[dice.Next(0, Fleet.airplanes.Count)];

                int type = dice.Next(1, 3); // SETTING THE TYPE; EITHER NATIONAL OR INTERNATIONAL
                string origin;
                string destination;
                int maxSeats = airplane.SeatsTotal;
                int maxPremSeats = airplane.SeatsPremium;
                int occupiedPremSeats = 0;
                int maxTourSeats = airplane.SeatsTourist;
                int occupiedTourSeats = 0;
                int flightDuration = 0;
                TimeSpan duration;
                float price = 0;

                // ------- SETTING THE ORIGIN AND DESTINATION
                // ------- THERE'S A RANDOM CHANCE FOR THE FLIGHT TO BE EITHER NATIONAL OR INTERNATIONAL.

                if (type == 1) // ... IF THE FLIGHT IS NATIONAL...
                {
                    int originIndex = dice.Next(0, nationalLocations);
                    int destinationIndex;

                    do
                    {
                        destinationIndex = dice.Next(0, nationalLocations);
                    } while (destinationIndex == originIndex);


                    origin = ((National)originIndex).ToString();
                    destination = ((National)destinationIndex).ToString();


                    for (int d = 0; d < 2; d++) // PARSING THE ENUM RIGHT
                    {
                        string str;
                        if (d == 0)
                        {
                            str = origin;
                        }
                        else
                        {
                            str = destination;
                        }

                        switch (str)
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
                        }

                        if (d == 0)
                        {
                            origin = str;
                        }
                        else
                        {
                            destination = str;
                        }
                    } // I FINISH PARSING BOTH ORIGIN AND DESTINATION

                    flightDuration = dice.Next(120, 241); // RANDOM FLIGHT DURATION
                    duration = TimeSpan.FromMinutes(flightDuration);
                    //price = 50; // SETTING THE TOURIST SEAT PRICE
                    price = ((flightDuration / 60) * 50);
                }
                else // ... IF THE FLIGHT IS INTERNATIONAL
                {
                    origin = "Buenos Aires";
                    int destinationIndex = dice.Next(0, internationalLocations);
                    destination = ((International)destinationIndex).ToString();

                    string str = destination;

                    switch (str)
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

                    destination = str;

                    flightDuration = dice.Next(480, 721);
                    duration = TimeSpan.FromMinutes(flightDuration);
                    //price = 100;
                    price = ((flightDuration / 60) * 100);
                }

                // ------- PLACING THE SEATS, TIDYING THE PLANE

                SortedDictionary<int, Passenger> premium = new SortedDictionary<int, Passenger>();
                SortedDictionary<int, Passenger> tourist = new SortedDictionary<int, Passenger>();

                // ------- NOW IT'S TIME TO EMBARK THE PASSENGERS

                for (int j = 0; j < passengers.Count; j++)
                {
                    int chancesToEmbark = dice.Next(1, 3); // THERE'S A 50% FOR THE PASSANGER TO EMBARK. NOT EVERYBODY TRAVELS...
                    
                    if(chancesToEmbark == 1)
                    {
                        int passengerType = dice.Next(1, 3); // PICKING A RANDOM TYPE OF PASSENGER CLASS

                        if (passengerType == 1)
                        {
                            if (occupiedPremSeats < maxPremSeats)
                            {
                                if (premium.Count > 0)
                                {
                                    premium.Add(premium.Keys.Last() + 1, passengers[j]);
                                    passengers[j].Flights++;
                                }
                                else
                                {
                                    premium.Add(1, passengers[j]);
                                    passengers[j].Flights++;
                                }
                            }
                            else
                            {
                                if (tourist.Count > 0)
                                {
                                    tourist.Add(tourist.Keys.Last() + 1, passengers[j]);
                                    passengers[j].Flights++;
                                }
                                else
                                {
                                    tourist.Add(1, passengers[j]);
                                    passengers[j].Flights++;
                                }
                            }
                        }
                        //----
                        else
                        {
                            if (occupiedTourSeats < maxTourSeats)
                            {
                                if (tourist.Count > 0)
                                {
                                    tourist.Add(tourist.Keys.Last() + 1, passengers[j]);
                                    passengers[j].Flights++;
                                }
                                else
                                {
                                    tourist.Add(1, passengers[j]);
                                    passengers[j].Flights++;
                                }
                            }
                            else
                            {
                                if (premium.Count > 0)
                                {
                                    premium.Add(premium.Keys.Last() + 1, passengers[j]);
                                    passengers[j].Flights++;
                                }
                                else
                                {
                                    premium.Add(1, passengers[j]);
                                    passengers[j].Flights++;
                                }
                            }
                        }
                    }

                    // PASSENGERS EMBARKED!!
                }
                List<Luggage> luggage = new List<Luggage>();

                DateTime datetoday = DateTime.Now;

                int rndYear = dice.Next(2018, datetoday.Year+1);
                int rndMonth = dice.Next(1, 12);
                int rndDay = dice.Next(1, 28);
                int rndHour = dice.Next(1, 24);
                int rndMin = dice.Next(1, 60);
                int rndSec = dice.Next(1, 60);

                DateTime flightStart = new DateTime(rndYear, rndMonth, rndDay,rndHour,rndMin,rndSec);

                Flight daFlight = new Flight(airplane, origin, destination, tourist, premium, luggage, price, duration.ToString(@"hh\:mm") + " hours", flightStart.ToString(), (flightStart + duration).ToString());

                if(type == 1)
                {
                    earnedNational[0] += daFlight.FlightEarned;
                }
                else
                {
                    earnedInternational[0] += daFlight.FlightEarned;
                }
                earnedTotal[0] += daFlight.FlightEarned;

                //********************

                foreach (Destination destinationInList in destinations)
                {
                    if (destinationInList.DestinationP == destination)
                    {
                        destinationInList.Flights++;
                        destinationInList.Earned += daFlight.FlightEarned;
                        destinationInList.Passengers += (daFlight.AmountPassengers);
                        break;
                    }
                }

                history.Add(daFlight);
            }
        }
    }
}
