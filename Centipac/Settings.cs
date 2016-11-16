using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using System.Windows.Forms;

namespace Centipac
{
    public class Settings
    {
        public static Dictionary<string, ColorScheme> colorSchemes = new Dictionary<string, ColorScheme>()
        {
            { "Default", new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)},
            { "Amber", new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE)},
            { "Red", new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.LightBlue200, TextShade.WHITE) },
            { "Green", new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightBlue200, TextShade.WHITE) },
            { "Grey", new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.LightBlue200, TextShade.WHITE) }
        };   

        public static MaterialSkinManager.Themes getTheme(string theme)
        {
            switch (theme)
            {
                case "Light": return MaterialSkinManager.Themes.LIGHT;
                case "Dark": return MaterialSkinManager.Themes.DARK;
            }

            return MaterialSkinManager.Themes.LIGHT;
        }
        
        public static MaterialSkinManager changeSkin(string colorScheme, string theme, MaterialSkin.Controls.MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = getTheme(theme);
            materialSkinManager.ColorScheme = Settings.colorSchemes[colorScheme];

            Properties.Settings.Default["COLORSCHEME"] = colorScheme;
            Properties.Settings.Default.Save();

            return materialSkinManager;
        }     
    }
}
