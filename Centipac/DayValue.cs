using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centipac
{
    /// <summary>
    /// Used for serialization in TimePicker.cs, holds an employees name in relation to a DayValue.
    /// </summary>
    public class NameDayValue
    {
        public string name;
        public Dictionary<string, DayValue> scheduleData = new Dictionary<string, DayValue>();

        public NameDayValue(string name, Dictionary<string, DayValue> scheduleData)
        {
            this.name = name;
            this.scheduleData = scheduleData;
        }
    }

    /// <summary>
    /// Holds the values of timepicker labels and the values of timepickers for serialization and
    /// reintializing timepicker values on load.
    /// </summary>
    public class DayValue
    {
        public int offset;
        public int value;
        public string text;

        /// <summary>
        /// Initializes class, called in TimePicker.
        /// </summary>
        /// <param name="_offset">Offset property in TimePicker.</param>
        /// <param name="_value">Value property in TimePicker.</param>
        /// <param name="_text">Text property in TimePicker.</param>
        public DayValue(int _offset, int _value, string _text)
        {
            offset = _offset; value = _value; text = _text;
        }
    }
}
