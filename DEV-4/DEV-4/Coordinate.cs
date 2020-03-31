using System;

namespace DEV_4
{
    /// <summary>
    /// Structure cordinate
    /// </summary>
    public struct Coordinate
    {
        private double _x;
        private double _y;
        private double _z;
        const double minimalValue = 0;

        /// <summary>
        /// Method that set and return field x value 
        /// </summary>
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

        /// <summary>
        /// Method that set and return field y value 
        /// </summary>
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

        /// <summary>
        /// Method that set and return field z value 
        /// </summary>
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

        /// <summary>
        /// Constructor for structure coordinate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Coordinate(double x, double y, double z)
        {
            _x = minimalValue;
            _y = minimalValue;
            _z = minimalValue;
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Method that calculates the distance between 2 points
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns> Distance between 2 points </returns>
        public double DistanceBetweenTwoPoint(Coordinate coordinate)
        {
            return Math.Sqrt(Math.Pow(_x - coordinate.X, 2) + Math.Pow(_y - coordinate.Y, 2)
                    + Math.Pow(_z - coordinate.Z, 2));

        }
    }
}
