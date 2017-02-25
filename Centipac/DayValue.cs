using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centipac
{
    public class NameDayValue
    {
        public string name;
        Dictionary<string, DayValue> scheduleData = new Dictionary<string, DayValue>();

        public NameDayValue(string name, Dictionary<string, DayValue> scheduleData)
        {
            this.name = name;
            this.scheduleData = scheduleData;
        }
    }

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
