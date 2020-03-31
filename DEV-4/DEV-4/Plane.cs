using System;

namespace DEV_4
{
    class Plane : IFlyable
    {
        private Coordinate _currentPosition;
        const int startSpeed = 200;
        const int acceleration = 10;
        const int accelerationDistance = 10;
        const int maximumSpeed = 1500;

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

        public Plane(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        public void FlyTo(Coordinate Coordinate)
        {
            CurrentPosition = Coordinate;
        }

        public DateTime GetFlyTime(Coordinate Coordinate)
        {
            DateTime time = DateTime.Now;
            int speed = startSpeed;
            double flightTime = 0;
            double distance = CurrentPosition.DistanceBetweenTwoPoint(Coordinate);

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
