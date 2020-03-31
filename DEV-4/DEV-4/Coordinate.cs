using System;

namespace DEV_4
{
    public struct Coordinate
    {
        private double _x;
        private double _y;
        private double _z;

        const double minimalValue = 0;

        public double X
        {
            set
            {
                if (value < minimalValue)
                {
                    throw new ArgumentException();
                }
                _x = value;
            }
            get
            {
                return _x;
            }
        }

        public double Y
        {
            set
            {
                if (value < minimalValue)
                {
                    throw new ArgumentException();
                }
                _y = value;
            }
            get
            {
                return _y;
            }
        }

        public double Z
        {
            set
            {
                if (value < minimalValue)
                {
                    throw new ArgumentException();
                }
                _z = value;
            }
            get
            {
                return _z;
            }
        }
        public Coordinate(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public double DistanceBetweenTwoPoint(Coordinate coordinate)
        {
            if (coordinate is Coordinate) // ???
            {
                return Math.Sqrt(Math.Pow(_x - coordinate.X, 2) + Math.Pow(_y - coordinate.Y, 2)
                        + Math.Pow(_z - coordinate.Z, 2));
            }
            return 0;
        }
    }
}
