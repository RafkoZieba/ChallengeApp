namespace ChallengeApp.Tests
{
	public class EmployeeTests
	{
		[Test]
		public void TestStatisticMin()
		{
			// arrange
			var employee = new Employee("Jerzy I", "Jerzyk");

			employee.AddGrade(23);
			employee.AddGrade(52);
			employee.AddGrade(11);
			employee.AddGrade(64);

			// act
			var statistic = employee.GetStatistics();

			// assert
			Assert.AreEqual(11 , statistic.Min);
		}

        [Test]
        public void TestStatisticMax()
		{
			// arrange
			var employee = new Employee("Jerzy II", "Jerzyk");

			employee.AddGrade(43);
			employee.AddGrade(32);
			employee.AddGrade(12);
			employee.AddGrade(62);

			// act
			var statistic = employee.GetStatistics();

			// assert
			Assert.AreEqual(62 , statistic.Max);
		}

        [Test]
        public void TestStatisticAvg()
		{
			// arrange
			var employee = new Employee("Jerzy III", "Jerzyk");

			employee.AddGrade(4);
			employee.AddGrade(52);
			employee.AddGrade(10);
			employee.AddGrade(64);

			// act
			var statistic = employee.GetStatistics();

			// assert
			Assert.AreEqual(32.5, statistic.Average);
		}
	}
}