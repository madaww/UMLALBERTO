using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlalberto
{
    internal class MediumCategory : Category
    {
        public HighCategory highCategory;

        public MediumCategory(string text, Level level, HighCategory HighCategory)
        {
            this.text = text;
            this.level = level;
            this.highCategory = HighCategory;
        }
    }
}
