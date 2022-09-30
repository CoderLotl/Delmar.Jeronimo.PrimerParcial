using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class HandLuggage : Luggage
    {
        private float money;
        private string content;

        public HandLuggage(string tag, LuggageType luggage, int weight) : base(tag, luggage, weight)
        {
            this.money = MoneyGenerator();
            this.content = ContentGenerator();
        }

        private float MoneyGenerator()
        {
            Random randomMoney = new Random();
            float money = randomMoney.Next(1,2000);
            return money;
        }

        public override string ToString()
        {
            return "=== Content: ===\n\n" + content + "\nMoney: "+money.ToString("c2");
        }

        public override string ContentGenerator()
        {
            Random number = new Random();
            StringBuilder content = new StringBuilder();

            string[] commonContent = { "- a water bottle", "- a key", "- an alfajor", "- a pen" };
            string[] uncommonContent = { "- a pokeball", "- an iPhone14", "- a diskette", "- a well written prose... book" };
            string[] rareContet = { "- a byte", "- a bitcoin", "- a void method" };

            int contentAmount = number.Next(1, 6);

            for (int i = 0; i < contentAmount; i++)
            {
                int dice = number.Next(1, 10);
                if (dice < 6 && dice > 0)
                {
                    int anotherDice = number.Next(0, 4);
                    content.Append(commonContent[anotherDice]);
                }
                else if (dice < 9 && dice > 6)
                {
                    int anotherDice = number.Next(0, 4);
                    content.Append(uncommonContent[anotherDice]);
                }
                else
                {
                    int anotherDice = number.Next(0, 3);
                    content.Append(rareContet[anotherDice]);
                }

                if (i < contentAmount - 1)
                {
                    content.Append("\n");
                }
            }

            return content.ToString();
        }
    }
}
