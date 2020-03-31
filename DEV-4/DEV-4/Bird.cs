using System;

namespace DEV_4
{
    /// <summary>
    /// Class bird
    /// </summary>
    public class Bird : IFlyable
    {
        private Coordinate _currentPosition;
        private int _speed;

        const int minimalSpeed = 0;
        const int maximalSpeed = 20;

        /// <summary>
        /// Method that set and return field current position value
        /// </summary>
        public Coordinate CurrentPosition 
        {
            set
            {
                _currentPosition = value;
            }
            get
            {
                return _currentPosition;
            }
        }

        /// <summary>
        /// Method that set and return field speed value
        /// </summary>
        public int Speed
        {
            set
            {
                _speed = value;
            }
            get
            {
                return _speed;
            }
        }

        /// <summary>
        /// Constructor for class drone
        /// </summary>
        /// <param Current position of bird ="currentPosition"></param>
        public Bird(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
            Random random = new Random();
            Speed = random.Next(minimalSpeed, maximalSpeed);
        }

        /// <summary>
        ///  Method for change the value of current position
        /// </summary>
        /// <param New position of the bird ="coordinate"></param>
        public void FlyTo(Coordinate coordinate)
        {
            CurrentPosition = coordinate;
        }

        /// <summary>
        /// Method for getting flight time
        /// </summary>
        /// <param New position of the bird ="coordinate"></param>
        /// <returns> Arrival time </returns>
        public DateTime GetFlyTime(Coordinate coordinate)
        {
            if (Speed == minimalSpeed) 
            {
                throw new ArgumentException();
            }
            DateTime time = DateTime.Now;
            return time.AddHours(coordinate.DistanceBetweenTwoPoint(CurrentPosition) / Speed);
        }
    }
}
