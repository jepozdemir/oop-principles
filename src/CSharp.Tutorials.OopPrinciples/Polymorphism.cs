namespace CSharp.Tutorials.OopPrinciples
{
	internal class Polymorphism
	{
		public void Run()
		{
			Shape circle = new Circle();
			Shape rectangle = new Rectangle();

			DrawShape(circle);    // Output: Drawing a circle
			DrawShape(rectangle); // Output: Drawing a rectangle
		}

		private void DrawShape(Shape shape)
		{
			shape.Draw();
		}

		// Base class
		class Shape
		{
			public virtual void Draw()
			{
				Console.WriteLine("Drawing a shape");
			}
		}

		// Derived class overriding the Draw method
		class Circle : Shape
		{
			public override void Draw()
			{
				Console.WriteLine("Drawing a circle");
			}
		}

		// Another derived class overriding the Draw method
		class Rectangle : Shape
		{
			public override void Draw()
			{
				Console.WriteLine("Drawing a rectangle");
			}
		}
	}
}
