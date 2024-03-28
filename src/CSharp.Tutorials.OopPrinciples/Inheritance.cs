namespace CSharp.Tutorials.OopPrinciples
{
	internal class Inheritance
	{
		public void Run()
		{
			Dog myDog = new Dog();

			// Inherited from Animal
			myDog.Eat();

			// Inherited from Animal
			myDog.Sleep();

			// Specific to Dog
			myDog.Bark();
		}

		class Animal
		{
			public void Eat()
			{
				Console.WriteLine("Animal is eating.");
			}

			public void Sleep()
			{
				Console.WriteLine("Animal is sleeping.");
			}
		}

		class Dog : Animal
		{
			public void Bark()
			{
				Console.WriteLine("Dog is barking.");
			}
		}
	}
}
