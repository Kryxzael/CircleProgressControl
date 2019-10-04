using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleControl
{
    /// <summary>
    /// A simple circular progress control
    /// </summary>
    public class CircleProgressControl : UserControl
    {
        private Pen _drawPen;
        private float _maxValue = 1;
        private float _value;
        private Pen _circleTrackPen;
        /// <summary>
        /// Gets or sets the amount of pixels the circle will have as width
        /// </summary>
        public float Boldness
        {
            get => _drawPen.Width;
            set
            {
                _circleTrackPen.Width = value;
                _drawPen.Width = value;
                Refresh();
            }
        }

        /// <summary>
        /// Gets or sets the maximum value of the control
        /// </summary>
        public virtual float MaxValue
        {
            get => _maxValue;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("MaxValue must be a positive non-zero number");
                }
                _maxValue = value;
                Refresh();
            }
        }

        /// <summary>
        /// Gets or sets the current value of the control
        /// </summary>
        public virtual float Value
        {
            get => _value;
            set
            {
                _value = value;
                Refresh();
            }
        }



        /// <summary>
        /// Gets or sets the color of the circle
        /// </summary>
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                _drawPen.Color = value;
                base.ForeColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the track that is displayed behind the circle
        /// </summary>
        public virtual Color CircleTrackColor
        {
            get => _circleTrackPen.Color;
            set
            {
                _circleTrackPen.Color = value;
                Refresh();
            }
        }

        public CircleProgressControl()
        {
            _drawPen = new Pen(ForeColor, 25f);
            _drawPen.EndCap = _drawPen.StartCap = LineCap.Round;
            _circleTrackPen = new Pen(Color.FromArgb(32, Color.Black), _drawPen.Width);

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(_circleTrackPen, CreateCircle(1f, ClientRectangle, Boldness));
            e.Graphics.DrawPath(_drawPen, CreateCircle(Value / MaxValue, ClientRectangle, Boldness));

            base.OnPaint(e);
        }

        public static GraphicsPath CreateCircle(float fill, Rectangle bounds, float boldness)
        {
            
            try
            {
                RectangleF boundsShrunk = bounds;
                boundsShrunk.Inflate(boldness / -2, boldness / -2);

                if (boundsShrunk.Width < 0)
                {
                    bounds.Width = 0;
                }

                if (boundsShrunk.Height < 0)
                {
                    bounds.Height = 0;
                }

                GraphicsPath path = new GraphicsPath();
                path.AddArc(boundsShrunk, -90, fill * 360);

                return path;
            }

            //This occurs in the preview of visual studio for some reason
            catch (Exception)
            {
                return new GraphicsPath();
            }


        }
    }
}
