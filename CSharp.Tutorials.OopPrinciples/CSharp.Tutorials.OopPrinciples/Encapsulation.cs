namespace CSharp.Tutorials.OopPrinciples
{
	internal class Encapsulation
	{
		public void Run()
		{
			BankAccount account = new BankAccount();
			account.Deposit(1000);
			account.Withdraw(500);
			Console.WriteLine($"Current balance: {account.GetBalance()}");
		}

		class BankAccount
		{
			private decimal balance;

			public void Deposit(decimal amount)
			{
				// Balance is modified only within this class
				balance += amount;
				Console.WriteLine($"Deposited {amount}. New balance: {balance}");
			}

			public void Withdraw(decimal amount)
			{
				// Balance is modified only within this class
				if (amount <= balance)
				{
					balance -= amount;
					Console.WriteLine($"Withdrawn {amount}. New balance: {balance}");
				}
				else
				{
					Console.WriteLine("Insufficient funds.");
				}
			}

			public decimal GetBalance()
			{
				// Balance is accessed only through a controlled method
				return balance;
			}
		}
	}
}
