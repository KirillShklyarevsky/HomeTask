using System;

namespace DEV_4
{
    public struct Coordinate
    {
        private double _x;
        private double _y;
        private double _z;

        public Coordinate(double x, double y, double z)
        {
            if (x < 0 || y < 0 || z < 0)
            {
                throw new ArgumentException();
            }

            _x = x;
            _y = y;
            _z = z;
        }
    }
}
