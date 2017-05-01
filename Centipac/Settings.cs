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
        //  Theme presets
        public static Dictionary<string, ColorScheme> colorSchemes = new Dictionary<string, ColorScheme>()
        {
            { "Default", new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)},
            { "Amber", new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE)},
            { "Indigo", new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE) },
            { "Green", new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE) },
            { "Grey", new ColorScheme(Primary.Grey500, Primary.Grey700, Primary.Grey100, Accent.LightBlue200, TextShade.WHITE) }
        };   

        /// <summary>
        /// Method to get theme enumerator objects from a string.
        /// </summary>
        /// <param name="theme">"Light" or "Dark" string values.</param>
        /// <returns>Themes enumeration value for given string.</returns>
        public static MaterialSkinManager.Themes getTheme(string theme)
        {
            switch (theme)
            {
                case "Light": return MaterialSkinManager.Themes.LIGHT;
                case "Dark": return MaterialSkinManager.Themes.DARK;
            }

            return MaterialSkinManager.Themes.LIGHT;
        }

        /// <summary>
        /// Used to change skins and initialize skins for new forms.
        /// </summary>
        /// <param name="colorScheme">ColorScheme from colorSchemes dictionary above.</param>
        /// <param name="theme">Light or Dark theme.</param>
        /// <param name="form">Form to set skin properties on.</param>
        /// <returns>Returns the MaterialSkinManager object.</returns>
        public static MaterialSkinManager changeSkin(string colorScheme, string theme, MaterialSkin.Controls.MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = getTheme(theme);
            materialSkinManager.ColorScheme = Settings.colorSchemes[colorScheme];

            Properties.Settings.Default["COLORSCHEME"] = colorScheme;
            Properties.Settings.Default["THEME"] = theme;
            Properties.Settings.Default.Save();

            form.Icon = Properties.Resources.iconC;

            return materialSkinManager;
        }  
    }
}
