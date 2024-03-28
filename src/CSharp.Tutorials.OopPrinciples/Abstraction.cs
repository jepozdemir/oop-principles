namespace CSharp.Tutorials.OopPrinciples
{
	internal class Abstraction
	{
		public void Run()
		{
			Shape circle = new Circle();
			Shape rectangle = new Rectangle();

			circle.Draw();      // Output: Drawing a circle
			rectangle.Draw();   // Output: Drawing a rectangle
		}

		// Abstract class representing a shape
		abstract class Shape
		{
			// Abstract method with no implementation details

			public abstract void Draw();
		}

		// Concrete class representing a circle
		class Circle : Shape
		{
			public override void Draw()
			{
				Console.WriteLine("Drawing a circle");
			}
		}

		// Concrete class representing a rectangle
		class Rectangle : Shape
		{
			public override void Draw()
			{
				Console.WriteLine("Drawing a rectangle");
			}
		}
	}
}
