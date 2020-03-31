using System;

namespace DEV_4
{
    /// <summary>
    /// Class drone
    /// </summary>
    public class Drone : IFlyable
    {
        Coordinate _currentPosition;
        const double speed = 20;
        const double stopPeriod = 1 / 6;
        const double stopTime = 1 / 60;
        const double maximumRange = 1000;

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
        /// Constructor for class drone
        /// </summary>
        /// <param Current position of drone ="currentPosition"></param>
        public Drone(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        /// <summary>
        /// Method for change the value of current position
        /// </summary>
        /// <param New position of the drone ="coordinate"></param>
        public void FlyTo(Coordinate coordinate)
        {
            if (coordinate.DistanceBetweenTwoPoint(CurrentPosition) > maximumRange)
            {
                throw new ArgumentException();
            }
            CurrentPosition = coordinate;
        }

        /// <summary>
        /// Method for getting flight time
        /// </summary>
        /// <param New position of the drone ="coordinate"></param>
        /// <returns> Arrival time </returns>
        public DateTime GetFlyTime(Coordinate coordinate)
        {
            double distance = CurrentPosition.DistanceBetweenTwoPoint(coordinate);

            if (distance > maximumRange)
            {
                throw new ArgumentException();
            }

            double stopDistance = speed * stopPeriod;
            int numberOfStops = (int)(distance / stopDistance);
            double timeForTrip = distance / speed + numberOfStops * stopTime;
            DateTime timeNow = DateTime.Now;
            return timeNow.AddHours(timeForTrip);
        }
    }
}
