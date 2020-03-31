using System;

namespace DEV_4
{
    class Drone : IFlyable
    {
        Coordinate _currentPosition;
        const double speed = 20;
        const double stopPeriod = 1 / 6;
        const double stopTime = 1 / 60;
        const double maximumRange = 1000;

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

        public Drone(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        public void FlyTo(Coordinate Coordinate)
        {
            if (_currentPosition.DistanceBetweenTwoPoint(Coordinate) > maximumRange)
            {
                throw new ArgumentException();
            }
            CurrentPosition = Coordinate;
        }

        public DateTime GetFlyTime(Coordinate Coordinate)
        {
            double distance = CurrentPosition.DistanceBetweenTwoPoint(Coordinate);

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
