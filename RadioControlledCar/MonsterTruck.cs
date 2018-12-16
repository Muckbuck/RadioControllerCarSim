using System;

namespace RadioControlledCar
{
    class MonsterTruck : Car
    {
        
        public MonsterTruck(int positionX, int positionY, char direction)
        {
            direction = Char.ToLower(direction);

            if(positionX < 0 || positionY < 0)
            {
                throw new ArgumentException("The x and y coordinate need to both be positive integers.");
            }
            if(!Array.Exists(validDirections, validDirection => validDirection == direction))
            {
                throw new ArgumentException("The the direction has to be one of the following: n,s,w,e.");
            }

            _position.x = positionX;
            _position.y = positionY;
            _direction = direction;
        }

        private char[] validDirections = { 'n', 's', 'w', 'e' };

        public  int _speed { get; set; }
        public  char _direction { get; set; }

        // Moves the car forward(f) or backwards(b) in x or y _direction
        // depending on the current _direction(w,e,n,s) and updates _position.
        public override void Move(char command)
        {
            switch (_direction)
            {
                case 'n' :
                    _position.x = command == 'f' ? _position.x + 1 : _position.x - 1;
                    break;
                case 's':
                    _position.x = command == 'f' ? _position.x - 1 : _position.x + 1;
                    break;
                case 'w':
                    _position.y = command == 'f' ? _position.y - 1 : _position.y + 1;
                    break;
                case 'e':
                    _position.y = command == 'f' ? _position.y + 1 : _position.y - 1;
                    break;
            }
        }

        // Rotates the car 90 degrees, either left or right
        // Updates the _direction depending on current _direction and command
        public override void Rotate(char command)
        {
            switch (_direction)
            {
                case 'n':
                    _direction = command == 'l' ? 'w' : 'e';
                    break;
                case 's':
                    _direction = command == 'l' ? 'e' : 'w';
                    break;
                case 'w':
                    _direction = command == 'l' ? 's' : 'n';
                    break;
                case 'e':
                    _direction = command == 'l' ? 'n' : 's';
                    break;     
            }

        }

    }
}
