using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Baggage : Luggage
    {
        private string content;

        public Baggage(string tag, LuggageType luggage, int weight) : base(tag, luggage, weight)
        {
            this.content = ContentGenerator();
        }

        public override string ToString()
        {
            return "=== Content: ===\n\n"+content+EmitSound();
        }

        public override string ContentGenerator()
        {
            Random number = new Random();
            StringBuilder content = new StringBuilder();
            
            string[] commonContent = {"- a handwatch", "- a pair of trousers", "- a book", "- an unsuspicious sealed tupper" };
            string[] uncommonContent = {"- a WWII militar tag", "- a superior education diploma", "- a handgun", "- a wizard staff" };
            string[] rareContet = {"- an abstract class", "- a tied up person", "- a 2A class passed exam"};

            int contentAmount = number.Next(1, 6);            

            for (int i = 0; i < contentAmount; i++)
            {
                int dice = number.Next(1, 10);
                if (dice < 6 && dice > 0)
                {
                    int anotherDice = number.Next(0, 4);
                    content.Append(commonContent[anotherDice]);
                }
                else if(dice < 9 && dice > 6)
                {
                    int anotherDice = number.Next(0, 4);
                    content.Append(uncommonContent[anotherDice]);
                }
                else
                {
                    int anotherDice = number.Next(0, 3);
                    content.Append(rareContet[anotherDice]);
                }

                if(i<contentAmount - 1)
                {
                    content.Append("\n");
                }
            }            

            return content.ToString();
        }

        public string EmitSound()
        {
            Random number = new Random();
            string whatsInside = "";

            int dice = number.Next(1,101);

            if(dice >= 1 && dice < 20)
            {
                whatsInside = "\n\n(The baggage emits a suspicios sound...)";
            }
            else if(dice >20 && dice < 40)
            {
                whatsInside = "\n\n(The baggage barks!!...)";
            }

            return whatsInside;
        }

    }
}
