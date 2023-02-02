//using static System.Formats.Asn1.AsnWriter;

namespace ChallengeApp
{
	class Employee
	{
		private List<int> Score = new List<int>();
		public static int nic;
		public Employee() { }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public void AddScore(int number) { this.Score.Add(number); }
		public int Result { get { return this.Score.Sum(); } }
		public void ShowFullEployerData()
		{

			Console.WriteLine($"{this.Name} {this.Surname}");
			Console.WriteLine($"wiek {this.Age} lata");
			Console.Write($"{this.Score.Sum()} punkty ");
			Console.Write(" suma z [");
			foreach (int score in this.Score)
			{
				
				Console.Write($"{score}, ");
			}
			Console.Write("]");
		}
	}
}
