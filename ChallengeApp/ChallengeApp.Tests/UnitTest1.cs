namespace ChallengeApp.Tests
{
	public class Tests
	{
		[Test]
		public void Test1()
		{
			int age1 = 10;
			int age2 = 3;

			int result = age1 + age2;

			Assert.AreEqual(13 , result);
		}
	}
}