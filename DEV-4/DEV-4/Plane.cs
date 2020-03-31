using System;

namespace DEV_4
{
    /// <summary>
    /// Class plane
    /// </summary>
    public class Plane : IFlyable
    {
        private Coordinate _currentPosition;
        const int startSpeed = 200;
        const int maximumSpeed = 1500;
        const int acceleration = 10;
        const int accelerationDistance = 10;

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
        /// Constructor for class plane
        /// </summary>
        /// <param Current position of plane ="currentPosition"></param>
        public Plane(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        /// <summary>
        /// Method for change the value of current position
        /// </summary>
        /// <param New position of the plane ="coordinate"></param>
        public void FlyTo(Coordinate coordinate)
        {
            CurrentPosition = coordinate;
        }

        /// <summary>
        /// Method for getting flight time
        /// </summary>
        /// <param New position of the plane ="coordinate"></param>
        /// <returns> Arrival time </returns>
        public DateTime GetFlyTime(Coordinate coordinate)
        {
            DateTime time = DateTime.Now;
            int speed = startSpeed;
            double flightTime = 0;
            double distance = CurrentPosition.DistanceBetweenTwoPoint(coordinate);

            while (distance > 0)
            {
                flightTime += accelerationDistance / speed;
                speed += acceleration;
                distance -= accelerationDistance;
            }
            flightTime += distance / speed;
            
            return time.AddHours(flightTime);
        }
    }
}
