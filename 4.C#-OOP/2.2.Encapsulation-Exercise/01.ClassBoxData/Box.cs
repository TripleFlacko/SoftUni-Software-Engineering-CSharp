using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassBoxData
{
    public class Box
    {
        private const string ExceptionMessage = "{0} cannot be zero or negative.";
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessage, nameof(Length)));
                }
                else
                {
                    length = value;
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessage, nameof(Width)));
                }
                else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessage, nameof(Height)));
                }
                else
                {
                    height = value;
                }
            }
        }
        public double SurfaceArea()
        {
            double surfaceArea = 2 * (length * width) + 2 * (length * height) + 2 * (height * width);
            return surfaceArea;
        }
        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (length * height) + 2 * (width * height);
            return lateralSurfaceArea;
        }
        public double Volume()
        {
            double volume = length * width * height;
            return volume;
        }
        public override string ToString()
        {
            return $"Surface Area - {SurfaceArea():F2}{Environment.NewLine}" +
                $"Lateral Surface Area - {LateralSurfaceArea():F2}{Environment.NewLine}" +
                $"Volume - {Volume():F2}";
        }

    }
}
