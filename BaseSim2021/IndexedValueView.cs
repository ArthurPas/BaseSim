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

        public void Draw(Graphics g)
        {
            Rectangle r = new Rectangle(Position,Size);
            Pen p = new Pen(Color, Thickness);
            g.DrawString(IndexedValue.Name, new Font(Police,
            10, FontStyle.Regular), Brushes.Black, new Rectangle(new Point(Position.X+20, Position.Y+10), new Size(Size.Width, Size.Height/2)));
            g.DrawString(IndexedValue.Type.ToString(), new Font(Police,
            10, FontStyle.Regular), Brushes.Black, r.X+20, r.Y);
            g.DrawString(IndexedValue.MinValue.ToString(), new Font(Police,
            10, FontStyle.Regular), Brushes.Black,r.X, r.Y + 30);
            g.DrawString(IndexedValue.MaxValue.ToString(), new Font(Police,
            10, FontStyle.Regular), Brushes.Black, r.X+50, r.Y+30);
            g.DrawString(IndexedValue.Value.ToString(), new Font(Police,
           10, FontStyle.Bold), Brushes.Black, r.X+30, r.Y + 50);
            g.DrawRectangle(p, r);
        }

        public IndexedValueView(IndexedValue indexedValue,Point position,Size size)
        {
            IndexedValue = indexedValue;
            Position = position;
            Size = size;
            Thickness = 1;
            Color = Color.Red;
            Police ="Times New Roman";
        }
    }
}
