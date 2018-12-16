using System;

namespace RadioControlledCar
{
    struct Room
    {
        public Room(string measures)
        {
            string[] roommeasures = measures.Split(' ');

            _width = Int32.Parse(roommeasures[0]);
            _length = Int32.Parse(roommeasures[1]);

            if(roommeasures.Length > 2 || roommeasures.Length < 2)
            {
                throw new ArgumentException("Wrong number of inputs");
            }
            if(_length <= 0 || _width <= 0)
            {
                throw new ArgumentException("The measurements has to be above 0");
            }
        }

        public int _length { get; set; }
        public int _width { get; set; }       
    }
}
