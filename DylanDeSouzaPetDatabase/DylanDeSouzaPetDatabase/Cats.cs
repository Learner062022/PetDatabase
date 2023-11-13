using System;
using System.Collections.Generic;
using System.Text;

namespace DylanDeSouzaPetDatabase
{
    public class Cats : Pet 
    {
        public string pattern;

        public Cats(string pattern, bool chipped)
        {
            this.pattern = pattern;
            isChipped = chipped;
        }
    }
}
