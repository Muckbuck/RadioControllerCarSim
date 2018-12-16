Classes
-------

 - Car & MonsterTruck
	The reason for creating the abstract class Car and
	the derived Class MonsterTruck, is to be able to implement
	other types of cars in the future. And every car will problably
	have to move, rotate and have a position.
 - Controller & MonsterTruckController
	The reason here is very simular to the previous explanation
	with one difference. The abstract class Controller has an
    implementation(SetCommandSequence) which is a generic solution
	that every radio controlled vehicle could utilize. 

I choose to create the abstract methods because different cars
might move and rotate differently. In this case the MonsterTruck
rotates 90 degrees to either left or right where as another car
might rotate in 45 degrees and move diagonally.
And therefor a controller might have to handle differently as well.

Structs
-------
  
  - Position
	At first I thought about having position as a dictionary
	but then after some thinking and reading of the C# docs
	I stuck with struct. The main reason behind this is that 
	structs are made for this kind of implementation and I could
	also add a method to check if the current position of the car
	was outside of its given room like this: Car.position.IsOutOfBounds(Room). 
	
  - Room
	This is a much simpler struct which only takes a string in the constructor
	and delegates each part of the string to the properties _length and _width.
	

