using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDrawingApp
{
    public class DrawingModel
    {
        public List<List<Point>> lines;
        public DrawingModel()
        {
            lines = new List<List<Point>>();
        }

        public void AddLine(Point point)
        {
            List<Point> line = new List<Point>();
            line.Add(point);
            lines.Add(line);
        }

        public void ContinueLine(Point point)
        {
            lines[lines.Count - 1].Add(point);
        }

        public void Clear()
        {
            lines.Clear();
        }
    }
}
