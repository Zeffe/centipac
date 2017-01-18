using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centipac
{
    public class DayValue
    {
        public int offset;
        public int value;
        public string text;

        public DayValue(int _offset, int _value, string _text)
        {
            offset = _offset; value = _value; text = _text;
        }
    }
}
