using System;
using System.Collections.Generic;
using System.Text;

namespace DylanDeSouzaPetDatabase
{
    public class Horses : Pet
    {
        public double hands;

        public Horses(double hands, string breed)
        {
            this.hands = hands;
            this.breed = breed;
        }
    }
}
