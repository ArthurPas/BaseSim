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
            Point Position = new Point(10, 10); 
                Rectangle r = new Rectangle(Position, new Size(100,100));
                Pen p = new Pen(Color, Thickness);
                g.DrawString(IndexedValue.ToString(), new Font(Police,
                15, FontStyle.Bold), Brushes.Fuchsia, Position);
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
