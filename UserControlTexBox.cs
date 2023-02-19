using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANWINDOWFORM
{
    [DefaultEvent("_TextChanged")]
    public partial class UserControlTexBox : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlineStyle = false;
        public UserControlTexBox()
        {
            InitializeComponent();
        }
        public event EventHandler _TextChanged;
        public event EventHandler _KeyPress;
        [Category("ControlTextBox")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        [Category("ControlTextBox")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        [Category("ControlTextBox")]
        public bool UnderlineStyle { get => underlineStyle; set { underlineStyle = value; this.Invalidate(); } }
        [Category("ControlTextBox")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
        [Category("ControlTextBox")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("ControlTextBox")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; textBox1.BackColor = value; }
        }
        [Category("ControlTextBox")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;

            }
        }
        [Category("ControlTextBox")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value; textBox1.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }
        [Category("ControlTextBox")]
        public string Texts { get => textBox1.Text; set => textBox1.Text = value; }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            using (Pen penBoder = new Pen(borderColor, borderSize))
            {
                penBoder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underlineStyle)
                {
                    graph.DrawLine(penBoder, 0, this.Height - 1, this.Width, this.Height - 1);

                }
                else graph.DrawRectangle(penBoder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                UpdateControlHeight();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.DesignMode)
            {
                UpdateControlHeight();
            }
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_KeyPress != null)
            {
                _KeyPress.Invoke(sender, e);
            }
        }
    }
}
