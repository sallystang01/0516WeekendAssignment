using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9Tutorials
{
    class Coin
    {
        // Field to represent the side facing up
        private string Sideup;
        Random rand = new Random();

        // Constructor
        public Coin()
        {
            Sideup = "Heads";
        }

        // The toss method simulates tossing the coin.

        public void Toss()
        {
            // Createa  random object.

            //Random rand =  new Random();

            // Use a random number to determine the side of the coin is facing up.
            // 0 = Heads, 1 = Tails

            if (rand.Next(2) == 0)
            {
                Sideup = "Heads";
            }

            else
            {
                Sideup = "Tails";
            }
        }

        //The GetSideUp method returns the value of the Sideup field.

        public string GetSideUp()
        {
            return Sideup;
        }
    }
}
