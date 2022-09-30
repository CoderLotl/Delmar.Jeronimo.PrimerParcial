using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    public enum LuggageType
    {
        HandLuggage,
        Baggage,
    }

    public abstract class Luggage
    {
        private string tag;
        private int weight;
        private LuggageType luggageType;        

        public Luggage(string tag, LuggageType luggage, int weight)
        {
            this.tag = tag;
            this.luggageType = luggage;
            this.weight = weight;
        }

        public string Tag { get => this.tag; }
        public int Weight { get => this.weight; }
        public LuggageType LuggageType { get => this.luggageType; }
        public abstract string ContentGenerator();
    }
}
