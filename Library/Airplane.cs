using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Airplane
    {           
        private string tag;
        private string pictureURL;
        private int seatsTotal;
        private int seatsPremium;
        private int seatsTourist;
        private int WCs;
        private int maxCargo;        
        
        private bool hasFood;
        private bool hasWifi;

        public Airplane(string tag, int seatsTotal,
            int wCs, int maxCargo, bool hasFood, bool hasWifi)
        {
            this.tag = tag;            
            this.seatsTotal = seatsTotal;
            this.seatsPremium = (int)(seatsTotal*0.2);
            this.seatsTourist = seatsTotal-seatsPremium;
            this.WCs = wCs;
            this.maxCargo = maxCargo;                      
            this.hasFood = hasFood;
            this.hasWifi = hasWifi;
            this.PictureURL = "default_plane.jpg";
        }

        public Airplane(string tag, int seatsTotal,
            int wCs, int maxCargo, bool hasFood, bool hasWifi, string picURL): this(tag,seatsTotal,wCs,maxCargo,hasFood,hasWifi)
        {            
            this.PictureURL = picURL;
        }

        public override string ToString()
        {
            return "////////////////////////[ PLANE ]////////////////////////\n\n" +
            "Tag: " + this.Tag + " | Max passengers: " + this.SeatsTotal + "\n\n" +
            "Premium seats: " + this.SeatsPremium + " | Tourist seats: " + this.SeatsTourist + "\n\n" +
            "Bathrooms: " + this.WCs1 + " | Max cargo: " + this.MaxCargo + "\n\n" +
            "Has wifi: " + this.HasWifi + " | Offers food: " + this.HasFood; ;
        }
        public string Tag { get => tag; set => tag = value; }        
        public int SeatsTotal { get => seatsTotal; set => seatsTotal = value; }
        public int SeatsPremium { get => seatsPremium; set => seatsPremium = value; }
        public int SeatsTourist { get => seatsTourist; set => seatsTourist = value; }
        public int WCs1 { get => WCs; set => WCs = value; }        
        public int MaxCargo { get => maxCargo; set => maxCargo = value; }
        public string PictureURL { get => pictureURL; set => pictureURL = value; }        
        public bool HasFood { get => hasFood; set => hasFood = value; }
        public bool HasWifi { get => hasWifi; set => hasWifi = value; }
    }
}
