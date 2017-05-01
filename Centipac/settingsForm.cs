using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centipac
{
    /// <summary>
    /// Form used only for changing theme settings.
    /// </summary>
    public partial class settingsForm : MaterialSkin.Controls.MaterialForm
    {
        public settingsForm()
        {
            InitializeComponent();

            Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, ColorScheme> entry in Settings.colorSchemes)
            {
                comboColorScheme.Items.Add(entry.Key);
            }

            comboColorScheme.SelectedItem = Properties.Settings.Default["COLORSCHEME"].ToString();
            comboTheme.SelectedItem = Properties.Settings.Default["THEME"].ToString();
        }

        private void comboColorScheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.changeSkin(comboColorScheme.SelectedItem.ToString(), Properties.Settings.Default["THEME"].ToString(), this);
        }

        private void comboTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), comboTheme.SelectedItem.ToString(), this);
        }

        private void settingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.settings = null;
        }
    }
}
