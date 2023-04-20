using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLength;
        double roomWidth;
        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidth);
        }
        public double RoomArea()
        {
            return (roomLength * roomWidth);
        }
        public double RoomPersonArea(int np)
        {
            return RoomArea() / np;
        }
        public virtual string Info()
        {
            return "Комната площадью" + RoomArea() + "кв.м";
        }

    }

    public class LivingRoom : Room
    {
        int numWin;
        public int NumWin
        { get { return numWin; } set { numWin = value; } }

        public override string Info()
        {
            return "Жилая комната площадью" + RoomArea() + " кв.м, с" + numWin + " окнами";
        }

    }
    public class Office : Room
    {
        int numSockets;
            public int NumSockets
        { get { return numSockets; } set { numSockets = value; } }
        public int NumWorkplace()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numSockets, num);
        }
        public override string Info()
        {
            return "Офис на " + NumWorkplace() + " рабочих мест";
        }

    }


}
