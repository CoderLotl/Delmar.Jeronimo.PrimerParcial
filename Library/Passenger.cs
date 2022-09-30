using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library
{
    public class Passenger
    {
        private string name;
        private string lastName;
        private string gender;
        private bool onFly;
        private string dni;
        private int age;
        private int flights;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }        
        public string Dni { get => dni; set => dni = value; }
        public bool OnFly { get => onFly; set => onFly = value; }
        public int Flights { get => flights; set => flights = value; }

        public Passenger(string name, string lastName, string gender, string dni, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.gender = gender;
            this.dni = dni;
            this.age = age;
            this.flights = 0;
        }

        public override bool Equals(object obj)
        {
            Passenger passenger = obj as Passenger;

            return this.Dni == passenger.Dni;
        }

        public override int GetHashCode()
        {
            return (this.dni).GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder daPassanger = new StringBuilder();

            daPassanger.Append(this.name + "|");
            daPassanger.Append(this.lastName + "|");
            daPassanger.Append(this.gender + "|");
            daPassanger.Append(this.dni + "|");
            daPassanger.Append(this.age + "|");
            daPassanger.Append(this.flights + "|");

            return daPassanger.ToString();
        }
    }
}
