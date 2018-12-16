using System;

namespace RadioControlledCar
{
    class MonsterTruckController : Controller
    {
        
        public MonsterTruck _monsterTruck { get; set; }

        // Takes x, y coordinate and direction(n,s,w,e) as input 
        // and instantiates the car with an initial position.
        public override void InitCar()
        {
            try { 

                Console.WriteLine("Enter x and y position and direction separated with spaces.");

                string[] initSettings = Console.ReadLine().Split(' ');

                if (initSettings.Length > 3 || initSettings.Length < 3)
                {
                    throw new ArgumentException("Wrong number of inputs.");
                }

                int positionX = Int32.Parse(initSettings[0]);
                int positionY = Int32.Parse(initSettings[1]);
                char direction = Char.Parse(initSettings[2]);

                _monsterTruck = new MonsterTruck(positionX, positionY, direction);

                if (_monsterTruck._position.IsOutOfBounds(room))
                {
                    throw new ArgumentException("The position of the car is outside of the room.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "\n");
                InitCar();
            }
        }

        // Loops through the array and execute each command 
        // as either left(l), right(r), forward(f) or back(b).
        // Returns the result after the execution is done.
        public override void ExecuteCommandSequence()
        {
            try { 
                foreach (char command in commandSequence)
                {
                    if (command == 'l' || command == 'r')
                    { 
                        _monsterTruck.Rotate(command);
                    }
                    else
                    {
                        _monsterTruck.Move(command);
                    
                        if (_monsterTruck._position.IsOutOfBounds(room))
                        {
                            throw new Exception("The simulation ended unsuccessfully. The car drove in the the wall.");
                        }
                    }
                }
                Console.WriteLine("The simulation ended successfully at position {0},{1} and direction {2}",
                _monsterTruck._position.x, _monsterTruck._position.y, _monsterTruck._direction);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }
            
        }
    }
}
