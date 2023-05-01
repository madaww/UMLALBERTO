using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlalberto
{
    internal class LowCategory : Category
    {
        public HighCategory highCategory;
        public MediumCategory mediumCategory;
        public LowCategory(string text, Level level, HighCategory highCategory, MediumCategory mediumCategory)
        {
            this.text = text;
            this.level = level;
            this.highCategory = highCategory;
            this.mediumCategory = mediumCategory;
        }

    }
}
