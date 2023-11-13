using System;
using System.Collections.Generic;
using System.Text;

namespace DylanDeSouzaPetDatabase
{
    public class Dogs
    {
        public string breed;
        public bool isChipped;
        public Dogs(string breed, bool chipped) 
        {
            this.breed = breed;
            isChipped = chipped;
        }
    }
}
