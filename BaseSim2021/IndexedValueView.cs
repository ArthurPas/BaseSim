using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseSim2021
{
    class IndexedValueView
    {
        public IndexedValue IndexedValue;
        public Point Position { get; set; }
        public Size Size { get; set; }
        public int Thickness { get; set; } = 10;
        public Color Color { get; set; } = Color.Red;
        public String Police { get; set; } = "Times New Roman";
        public Color BgColor { get; set; }
        public void Draw(Graphics g)
        {
            StringFormat theFormat = new StringFormat();
            Rectangle r = new Rectangle(Position, Size);
            SolidBrush Brush = new SolidBrush(BgColor);
            g.FillRectangle(Brush, r);
            Pen p = new Pen(Color, Thickness);
            theFormat.Alignment = StringAlignment.Center;
            theFormat.LineAlignment = StringAlignment.Near;
            g.DrawString(IndexedValue.Type.ToString(), new Font(Police,
            10, FontStyle.Regular), Brushes.Black, r, theFormat);
            g.DrawString(IndexedValue.Name, new Font(Police,
            10, FontStyle.Regular), Brushes.Black, new Rectangle(new Point(Position.X, Position.Y + 10), new Size(Size.Width, Size.Height / 2)),theFormat);
            theFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(IndexedValue.Value.ToString(), new Font(Police,
            10, FontStyle.Bold), Brushes.Black, r, theFormat);
            theFormat.Alignment = StringAlignment.Near;
            theFormat.LineAlignment = StringAlignment.Far;
            g.DrawString(IndexedValue.MinValue.ToString(), new Font(Police,
            10, FontStyle.Regular), Brushes.Black, r, theFormat);
            theFormat.Alignment = StringAlignment.Far;
            g.DrawString(IndexedValue.MaxValue.ToString(), new Font(Police,
            10, FontStyle.Regular), Brushes.Black, r, theFormat);
            
            g.DrawRectangle(p, r);
        }

        public IndexedValueView(IndexedValue indexedValue, Point position, Size size, Color BackColor)
        {
            IndexedValue = indexedValue;
            Position = position;
            Size = size;
            Thickness = 1;
            Color = Color.Red;
            Police = "Times New Roman";
            BgColor = BackColor;
        }
        public bool Contains(Point p)
        {
            Rectangle rec = new Rectangle(Position, Size);
            return rec.Contains(p);
        }
    }
}
