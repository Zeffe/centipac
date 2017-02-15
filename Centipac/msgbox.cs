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
    public partial class msgbox : MaterialSkin.Controls.MaterialForm
    {

        public enum Buttons
        {
            NoButtons,
            OKButton,
            YesNoButtons,
            Input
        }

        public msgbox(String msg, String title, int type)
        {
            InitializeComponent();

            createMessage(msg, title, type);
        }

        public msgbox(String msg, String title, Buttons btn)
        {
            InitializeComponent();

            createMessage(msg, title, (int)btn);
        }

        string msgOut;

        void createMessage(String msg, String title, int type)
        {
            int cur = -1;
            for (int j = 1; j < msg.Length; j++)
            {
                for (int i = 0; i < 100; i++)
                {
                    cur++;
                    try
                    {
                        if (i > 50)
                        {
                            if (msg[cur] == ' ')
                            {
                                break;
                            }
                        }
                        msgOut += msg[cur];
                    }
                    catch
                    {
                        j += 100; break;
                    }
                }
                msgOut += "\n";
            }
            lblMessage.Text = msgOut;
            this.Text = title;
            this.Width = lblMessage.Width + 20;
            switch (type)
            {
                // Standard MessageBox
                case 0: this.Height += lblMessage.Height - 10; break;
                // OK Dialog
                case 1:
                    this.Height += lblMessage.Height + 10; btnOk.Visible = true;
                    btnOk.Location = new System.Drawing.Point(this.Width / 2 - btnOk.Width / 2, this.Height - 30);
                    break;
                // Yes/No Dialog
                case 2:
                    this.Height += lblMessage.Height + btnNo.Height - 10; btnYes.Visible = true; btnNo.Visible = true;
                    btnNo.Location = new System.Drawing.Point(this.Width - btnNo.Width - 10, this.Height - btnNo.Height - 10);
                    btnYes.Location = new System.Drawing.Point(btnNo.Location.X - btnYes.Width - 5, btnNo.Location.Y);
                    break;
                // Input Dialog
                case 3:
                    this.Height += lblMessage.Height + 15 + txtInput.Height; btnOk.Visible = true; txtInput.Visible = true; btnOk.Text = "Submit";
                    txtInput.Width = this.Width - 10; btnOk.Width += 5;
                    txtInput.Location = new Point(this.Width / 2 - txtInput.Width / 2, this.Height - 15 - btnOk.Height - txtInput.Height);
                    btnOk.Location = new System.Drawing.Point(this.Width / 2 - btnOk.Width / 2, this.Height - 30);
                    break;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
