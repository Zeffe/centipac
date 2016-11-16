using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;

namespace Centipac
{
    public class Settings
    {
        public static Dictionary<string, ColorScheme> colorSchemes = new Dictionary<string, ColorScheme>()
        {
            { "Default", new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)},
            { "Amber", new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE) }
        };        
    }
}
