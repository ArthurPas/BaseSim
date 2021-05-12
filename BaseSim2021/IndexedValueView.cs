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
                g.DrawString(IndexedValue.ToString(), new Font(Police,
                10, FontStyle.Regular), Brushes.Black, Position);
                g.DrawRectangle(p, r);
        }

        public IndexedValueView(IndexedValue indexedValue,Point position,Size size,int thickness, Color color, string police)
        {
            IndexedValue = indexedValue;
            Position = position;
            Size = size;
            Thickness = thickness;
            Color = color;
            Police = police;
        }
    }
}
