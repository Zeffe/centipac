using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Centipac
{
    public partial class reportForm : MaterialSkin.Controls.MaterialForm
    {
        public reportForm()
        {
            InitializeComponent();
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            
        }

        private void reportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            managerForm.report = null;
        }
    }
}
