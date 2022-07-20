using FactoryPatternExercise;

Console.WriteLine("Pleas enter the number of wheels your vehicle has. 2 or 4. or is it a big haulin semi??");
var userInput = int.Parse(Console.ReadLine());
IVehicle myVehicle = VehicleFactory.GetVehicle(userInput);

myVehicle.Drive();

