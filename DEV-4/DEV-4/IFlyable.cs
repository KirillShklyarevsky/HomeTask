using System;

namespace DEV_4
{
    interface IFlyable
    {
        void FlyTo(Coordinate coordinate);
        Coordinate GetFlyTime(Coordinate coordinate);
    }
}
