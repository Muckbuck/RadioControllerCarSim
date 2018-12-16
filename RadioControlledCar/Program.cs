using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioControlledCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller monsterTruckController = new MonsterTruckController();

            // Takes input for heght and width of the room and instatiats a new Room.
            void SetUpRoom()
            {
                try {
                    Console.WriteLine("Enter width and length of the room as integers separated with space.");
                    string measures = Console.ReadLine();

                    Room room = new Room(measures);

                    monsterTruckController.room = room;
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message + "\n");
                    SetUpRoom();
                }
                
            }

            // Running the application
            SetUpRoom();
            monsterTruckController.InitCar();
            monsterTruckController.SetCommandSequence();
            monsterTruckController.ExecuteCommandSequence();
            Console.Write("Pressy any key to exit");
            Console.ReadKey();
            

        }
    }
}
