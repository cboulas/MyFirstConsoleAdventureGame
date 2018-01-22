using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAdventureGame.classes
{
    public class Range
    {
        private int _min = 1, _max = 1;

        public int minDamage
        {
            get { return _min; }
        }

        public int maxDamage
        {
            get { return _max; }
        }

        public Range(int min, int max)
        {
            _min = min;
            _max = max;
        }
    }
}
