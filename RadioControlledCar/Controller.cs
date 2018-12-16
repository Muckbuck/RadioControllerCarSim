using System;

namespace RadioControlledCar
{
    abstract class Controller
    {
  
        // Takes a string of commands as input and parses the string to char array.
        public void SetCommandSequence()
        {
            Console.WriteLine("Enter commands(f,b,l,r) as a sequense without any whitespace: ");
            commandSequence = Console.ReadLine().ToLower().ToCharArray();

            try
            {
                foreach (char command in commandSequence)
                {
                    if (!Array.Exists(validCommands, validCommand => validCommand == command))
                    {
                        throw new ArgumentException("Each command in the sequence has to be one of the following: f,b,l,r.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
                SetCommandSequence();
            }
            
            
        }

        private char[] validCommands = { 'f', 'b', 'l', 'r' };
        protected char[] commandSequence;
        public Room room;

        public abstract void InitCar();
        public abstract void ExecuteCommandSequence();

    }
}
