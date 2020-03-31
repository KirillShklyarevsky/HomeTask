using System;

namespace DEV_4
{
    class Bird : IFlyable
    {
        private Coordinate _currentPosition;
        private int _speed;

        const int minimalSpeed = 0;
        const int maximalSpeed = 20;

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

        public Bird(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
            Random random = new Random();
            Speed = random.Next(minimalSpeed, maximalSpeed);
        }

        public void FlyTo(Coordinate Coordinate)
        {
            CurrentPosition = Coordinate;
        }

        public DateTime GetFlyTime(Coordinate Coordinate)
        {
            if (Speed == minimalSpeed) 
            {
                throw new ArgumentException();
            }
            DateTime time = DateTime.Now;
            return time.AddHours(Coordinate.DistanceBetweenTwoPoint(CurrentPosition) / );
        }
    }
}
