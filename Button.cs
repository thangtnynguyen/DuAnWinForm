﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.ComponentModel;

namespace DOANWINDOWFORM
{
    class ClassButton : Button
    {
        private int borderSize = 0;
        private int borderRadios = 40;
        private Color borderColor = Color.PaleVioletRed;//PaleVioletRed
        [Category("EditButton")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        [Category("EditButton")]
        public int BorderRadios { get => borderRadios; set { borderRadios = value; this.Invalidate(); } }
        [Category("EditButton")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        [Category("EditButton")]
        public Color BackgrondColor
        {
            get { return BackColor; }
            set { this.BackColor = value; }
        }
        [Category("EditButton")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
        [Category("EditButton")]
        public ClassButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumAquamarine;
            this.ForeColor = Color.White;
        }
        private GraphicsPath GetGraphicsPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectborder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            if (borderRadios > 2)
            {
                using (GraphicsPath pathSurface = GetGraphicsPath(rectSurface, borderRadios))
                using (GraphicsPath pathBorder = GetGraphicsPath(rectborder, borderRadios - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penSurface, pathSurface);

                    }

                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}


