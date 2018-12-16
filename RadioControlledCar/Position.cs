

namespace RadioControlledCar
{
    struct Position
    {
        // Sets the x and y coordinates.
        public Position(int positionX, int positionY)
        {
            x = positionX;
            y = positionY;
        }

        public int x { get; set; }
        public int y { get; set; }

        // Checks if the current position is outside its given room.
        public bool IsOutOfBounds(Room room)
        {
            if((x >= 0 && x <= room._width - 1) && (y >= 0 && y <= room._length - 1)) {
                return false;
            }
            else
            {
                return true;
            }         
        }
    }
}
