using System;

namespace DEV_4
{
    class Plane : IFlyable
    {
        private Coordinate _currentPosition;
        private int _speed;
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

        public Plane(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
            Speed = startSpeed;

        }

        public void FlyTo(Coordinate Coordinate)
        {
            CurrentPosition = Coordinate;
        }

        public DateTime GetFlyTime(Coordinate Coordinate)
        {
            DateTime time = DateTime.Now;
            double flightTime = 0;
            double distance = CurrentPosition.DistanceBetweenTwoPoint(Coordinate);
            double currentDistance = 0;

            while (distance < accelerationDistance && Speed < maximumSpeed)
            {
                flightTime += accelerationDistance / Speed;
                Speed += acceleration;
                distance -= accelerationDistance;
            }
            flightTime += distance / Speed;
            
            return time.AddHours(flightTime);
        }
    }
}
