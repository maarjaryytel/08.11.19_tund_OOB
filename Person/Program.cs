using System;

namespace Person
{

	class Program
	{
		static void Main(string[] args)
		{
			//loome ainult 1 klassi

			/*Person newPerson = new Person();
			newPerson.FirstName = "John";
			newPerson.LastName = "Doe";
			newPerson.Introduce();
			Console.ReadLine();*/

			Car myCar = new Car();
			myCar.model = "Superb";
			myCar.mark = "Skoda";
			myCar.regNumber = "123ABC";
			myCar.odo = 400;

			for (int i = 0; i < 10; i++)
			{
				myCar.Drive();
			}
			myCar.ShowOdo();

			Console.ReadLine();
		}
	}
}
