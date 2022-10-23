using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxCSharp
{
    public class ShapeBase
    {
        private string ShapeName { get; set; }
        public ShapeBase(string shapeName)
        {
            ShapeName = shapeName;
        }

        public override string ToString()
        {
            return $"Фигура: {ShapeName}";
        }
    }
}
