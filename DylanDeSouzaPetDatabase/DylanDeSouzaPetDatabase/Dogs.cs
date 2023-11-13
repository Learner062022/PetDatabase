using System;
using System.Collections.Generic;
using System.Text;

namespace DylanDeSouzaPetDatabase
{
    public class Dogs : Pet
    {
        public Dogs(string breed, bool chipped) 
        {
            this.breed = breed;
            isChipped = chipped;
        }
    }
}
