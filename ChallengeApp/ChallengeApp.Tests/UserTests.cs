namespace ChallengeApp.Tests
{
	public class Tests
	{
		[Test]
		public void CountingScore()
		{
            // arrange
            var user = new User();
            user.Name = "Jacek";
            user.Surname = "Kowalski";
            user.Age = 45;
			user.AddScore(45);
			user.AddScore(23);
			user.AddScore(-10);
			user.AddScore(-11);
			user.AddScore(-3);


			// act
			var result = user.Result;

			// assert
			Assert.AreEqual(44 , result);
		}
	}
}