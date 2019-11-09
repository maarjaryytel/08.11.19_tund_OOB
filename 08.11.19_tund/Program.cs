using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._11._19_tund
{ 
	//objektorinteeritud programmeerimine
	//klassidest loome objektid, obj oskavad midagi teha, objektidel on omadused

	//kuidas loome klassid//klassid käivad siia ülesse

	class Animal //klass on alati suure tähega
	{
		//kui ma tahan nekid omadusi hiljem kasutada, siis pean kasutama public

		public string name;
		public int age;
		public double levelOfHappiness; //double komakohtadega arv
		public double levelOfCuteness; //see on kassile

		//kui loome klassi, siis peame kirjut meetodi, mida tahame klassiga teha
		//kirjutatakse meetodit

		public void PrintAnimalBaseInfo()
		{
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"Level of hapiness: {levelOfHappiness}");
			

			//see loom on abstraktne, me ei tea, kas on kass, koer
		}

		public void ShowLewelOfHappiness() //soovime üksnes seda ünnetaset kuvada
		{
			Console.WriteLine($"level of hapiness: {levelOfHappiness}");
		}
		
	}
	//intheritance- pärimine
	class Dog : Animal //st et kõik need omadused ja meetodit saab selle koera puhul ka kasutada
	{
		public int spotCount = 0; //laigud, see on omadus
								  //kui koer haugub, siis las saab 5 täppi juurde

		//mitu korda koer haukus
		public int numbersOfBarks = 0; //alguses oli koer vaikne, ei haukunud

		public void Bark() //haukumine, see on meetod
		{
			Console.WriteLine("Wuf");
			levelOfHappiness += 0.1; //iga kord kui koer haugub, siis liidab juurde
									 //tahan kuvada ainult levelof happiness
									 //spotCount += 5;
			numbersOfBarks++;

			//iga kord kui koer haugub lisada randomiga juurde 1-5 täppi
			Random rnd = new Random();
			int randomNumberOfSpots = rnd.Next(0, 6); //mõnikord ei saa täppi kätte, seep 0.
			spotCount += randomNumberOfSpots;
		}
		public void ShowNumberOfDogSpots()
		{
			Console.WriteLine($"{name} has now {spotCount} number of spots.");
		}
    }
	class Cat : Animal
	{
		public double levelOfCuteness;

		public void Meow()//mjäu
		{
			Console.WriteLine($"meow!");
			levelOfCuteness -= 0.1;
			levelOfHappiness += 0.1; //kuvamiseks pean eraldi meetodi tegema
		}
		public void ShowLevelOfCuteness()
		{
			Console.WriteLine($"Cats level of cuteness: {levelOfCuteness}");
		}
		public void HearBarks(int numberOfBarks) //õpetasime kassi koera kuulama
		{
			levelOfHappiness = 0.1 * numberOfBarks;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			//animal on klassi nimi
			Animal nurr = new Animal();
			//kuvame
			nurr.name = "Nurr";
			nurr.age = 15;
			nurr.levelOfHappiness = 0.1; //see peab olema 0-1 vahel
			nurr.PrintAnimalBaseInfo(); //on tühi objekt, sellepärast ei kuva

			Cat miisu = new Cat();
			miisu.name = "Miisu";
			miisu.age = 2;
			miisu.levelOfHappiness = 0.5;
			miisu.levelOfCuteness = 1;

			for (int i = 0; i < 5; i++) //näugub 5 korda
			{
				miisu.Meow();
			}
			miisu.ShowLevelOfCuteness();

			Dog muri = new Dog (); //kirjeldan klassi dog
			//see muri on objekti nimi, see on muutuja, sellel muutujad on omadused
			//MuriDoo on juba nimi
			muri.name = "MuriDoo";
			muri.age = 13;
			muri.levelOfHappiness = 0.1;
			muri.spotCount = 5;
			
			muri.PrintAnimalBaseInfo(); //kuvamiseks
			muri.Bark(); //paneme haukuma 1 korda, kümme korda haukuma panemiseks teeme for loopi

			for (int i = 0; i < 20; i++)
			{
				muri.Bark();
			}
			muri.ShowLewelOfHappiness(); //kutsun ta välja, et näitaks õnnetunnet
			muri.ShowNumberOfDogSpots(); //kutsun ta välja, et näitaks mitu täppi on

			//kuidas ma kassi objekti loon
			/*Cat miisu = new Cat();
			miisu.name = "Miisu";
			miisu.age = 2;
			miisu.levelOfHappiness = 0.5;
			miisu.levelOfCuteness = 1;*/

			for (int i = 0; i < 5; i++) //näugub 5 korda
			{
				miisu.Meow();
			}

			miisu.HearBarks(muri.numbersOfBarks);

			//kontrollime miisu õnnetaset
			if (miisu.levelOfHappiness < 0)
			{
				Console.WriteLine($"{miisu.name} died of stress");
				miisu = null;
			}

			miisu.ShowLevelOfCuteness();

			//miisu = null; //tapame kassi ära, nullime andmed ära
			//miisu.PrintAnimalBaseInfo();

			Console.ReadLine();

		}		   
	}
}

