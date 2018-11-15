using System;

namespace CJTheNJLottery
{
	class Program
	{
		enum Day { PICK_3 = 1, PICK_4, JERSEY_CASH_5, PICK_6, POWERBALL, MEGA_MILLIONS };

		/**
		 * Pick five(5) numbers between 1-69 and one(1) Powerball number between 1-26.
		 * Powerball drawings are held every Wednesday & Saturday at approximately 10:59 pm.
		 */
		private static Tuple <int[], int> GetPowerBallNumbers()
		{
			Random random = new Random();
			int [] powerBall = { random.Next(70), random.Next(70), random.Next(70), random.Next(70), random.Next(70) };
			return new Tuple<int[], int>(powerBall, random.Next(26));
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Hello C.J and welcome back. Wish you success :-)\n");
			Console.WriteLine("Please select a raffle for the foolowing:");
			Console.WriteLine("------------------------------------------\n");
			Console.WriteLine("1) PICK-3 (not valid)");
			Console.WriteLine("2) PICK-4 (not valid)");
			Console.WriteLine("3) JERSEY CASH 5 (not valid)");
			Console.WriteLine("4) PICK-6 (not valid)");
			Console.WriteLine("5) POWERBALL");
			Console.WriteLine("6) MEGA MILLIONS (not valid)");
			int raffel = 0;
			try
			{
				raffel = int.Parse(Console.ReadLine());
			}
			catch (FormatException e)
			{
				Console.WriteLine("Please select a digit");
			}
			if (raffel > 0 && raffel <= 6) {
				switch (raffel)
				{
					case 1: Console.WriteLine("PICK-3 (Not valid)");
						break;
					case 2: Console.WriteLine("PICK-4 (Not valid)");
						break;
					case 3:
						Console.WriteLine("JERSEY CASH 5 (Not valid)");
						break;
					case 4:
						Console.WriteLine("PICK-6 (Not valid)");
						break;
					case 5:
						Console.WriteLine("--------------------------------\n");
						foreach (int value in GetPowerBallNumbers().Item1)
						{
							Console.Write("{0} ", value);
						}
						Console.WriteLine("and the extra number is "+GetPowerBallNumbers().Item2);
						break;
					case 6:
						Console.WriteLine("MEGA MILLIONS(Not valid)");
						break;
					default: Console.WriteLine("Not valid selection");
						break;
				}
			}
			else
			{
				Console.WriteLine("Not a valid selection. Please try again.");
			}
		}
	}
}
