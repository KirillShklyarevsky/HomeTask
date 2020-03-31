using System;

namespace DEV_4
{
    interface IFlyable
    {
        void FlyTo(Coordinate coordinate);
        DateTime GetFlyTime(Coordinate coordinate);
    }
}