

namespace RadioControlledCar
{
    abstract class Car
    {
       char _direction { get; set; }
       public Position _position;

       public abstract void Move(char command);
       public abstract void Rotate(char command); 
    }
}
