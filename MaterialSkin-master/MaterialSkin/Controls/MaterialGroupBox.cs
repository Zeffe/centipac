using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialGroupBox : GroupBox, IMaterialControl
    {
        [Browsable(false)]
        public MaterialSkinManager SkinManager { get { return MaterialSkinManager.Instance; } }
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        [Browsable(false)]
        public int Depth { get; set; }


        //Create the property backing fields
        private SolidBrush _BackColorBrush;
        private SolidBrush _PanelBrush;
        private Pen _BorderPen;
        private int diamond;

        //Set the Styles, pens, brushes, and properties used for the defaults when a new instance is created
        public MaterialGroupBox()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.Size = new Size(180, 100);
            diamond = 16;
            _BackColorBrush = new SolidBrush(Color.Transparent);
            _BorderPen = new Pen(Color.Black);
            _PanelBrush = new SolidBrush(SkinManager.GetApplicationBackgroundColor());
            base.BackColor = Color.Transparent;
        }

        //Create the properties for the control

        [Category("Appearance"), Description("Changes the position of the diamond in relation to the top right of the group box.")]
        [Browsable(true)]
        public int DiamondPos
        {
            get { return diamond; }
            set
            {
                diamond = value;
                this.Refresh();
            }
        }

        //Used to paint the control according to how the properties are set
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            var _with1 = e.Graphics;
            int diamondWidth = 16;
            int diamondHeight = 6;
            _with1.SmoothingMode = SmoothingMode.AntiAlias;
            _with1.FillRectangle(_BackColorBrush, 0, 0, this.Width, this.Height);
            Point[] pointArray = {
                new Point(diamond, diamondHeight),
                new Point(diamond + (diamondWidth/2), 0),
                new Point(diamond + diamondWidth, diamondHeight),
                new Point(this.Width - 1, diamondHeight),
                new Point(this.Width - 1, this.Height - 1),
                new Point(0, this.Height - 1),
                new Point(0, diamondHeight) };
            _with1.DrawPolygon(_BorderPen, pointArray);

            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddPolygon(pointArray);
                _with1.FillPath(new SolidBrush(SkinManager.GetApplicationBackgroundColor()), gp);
                _with1.DrawPath(_BorderPen, gp);
                _with1.DrawPolygon(_BorderPen, pointArray);               
            }
        }

        //Dispose of all brushes and pens used for the property backing fields
        protected override void Dispose(bool disposing)
        {
            _BackColorBrush.Dispose();
            _BorderPen.Dispose();
            _PanelBrush.Dispose();
            base.Dispose(disposing);
        }
    }
}
