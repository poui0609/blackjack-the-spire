using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_TheSpire.Scaler
{
    internal class FormScaler
    {
        private Form form;
        private float baseWidth;
        private float baseHeight;

        public float ScaleX => form.ClientSize.Width / baseWidth;
        public float ScaleY => form.ClientSize.Height / baseHeight;
        private struct ControlLayout
        {
            public float X, Y, Width, Height, FontSize;
        }

        private Dictionary<Control, ControlLayout> originalLayouts
            = new Dictionary<Control, ControlLayout>();

        public FormScaler(Form form)
        {
            this.form = form;

            baseWidth = form.ClientSize.Width;
            baseHeight = form.ClientSize.Height;

            RegisterAllControls(form);

            form.Resize += Form_Resize;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            ApplyScale();
        }

        private void RegisterAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                originalLayouts[ctrl] = new ControlLayout
                {
                    X = ctrl.Left,
                    Y = ctrl.Top,
                    Width = ctrl.Width,
                    Height = ctrl.Height,
                    FontSize = ctrl.Font.Size
                };

                if (ctrl.HasChildren)
                    RegisterAllControls(ctrl);
            }
        }

        public void ApplyScale()
        {
            if (form.WindowState == FormWindowState.Minimized)
                return;

            if (form.ClientSize.Width == 0 || form.ClientSize.Height == 0)
                return;

            float scaleX = form.ClientSize.Width / baseWidth;
            float scaleY = form.ClientSize.Height / baseHeight;

            foreach (var pair in originalLayouts)
            {
                Control ctrl = pair.Key;
                ControlLayout layout = pair.Value;

                ctrl.Left = (int)(layout.X * scaleX);
                ctrl.Top = (int)(layout.Y * scaleY);
                ctrl.Width = (int)(layout.Width * scaleX);
                ctrl.Height = (int)(layout.Height * scaleY);

                float fontScale = Math.Min(scaleX, scaleY);

                ctrl.Font = new Font(
                    ctrl.Font.FontFamily,
                    Math.Max(1f, layout.FontSize * fontScale),
                    ctrl.Font.Style);
            }
        }
    }
}

