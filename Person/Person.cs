using System;

namespace Person
{
	/*public class Person
	{
		//fileds
		public string FirstName;
		public string LastName;
		// tahan, et isik tutvustaks ennast

		public void Introduce()
		{
			Console.WriteLine($"Hello, my name is: {FirstName} {LastName}");
		}
	}*/
	public class Car //klass on nimisõna ja funktsioon on tegusõna
	{
		public string mark;
		public string model;
		public string color;
		public string regNumber;
		public int odo = 0; //alguses on odomeetri näit 0


		public void Drive() //tahan et auto sõidaks
		{
			odo += 100; //kui ta sõidab, siis odomeetri näit suureneb

		}

		//tahan kuvada
		public void ShowOdo()
		{
		Console.WriteLine($"The car has driven {odo} km.");
		}
    }
}
