using ChallengeApp;

Random Random = new Random();

User user1 = new User(); 
user1.Name = "Jacek"; 
user1.Surname = "Kowalski"; 
user1.Age = Random.Next(18, 70); 

for(int i = 0; i < 5; i++) 
{ 
	user1.AddScore(Random.Next(100)); 
}
User user2 = new User(); 
user2.Name = "Michal"; 
user2.Surname = "Zawadzki"; 
user2.Age = Random.Next(18, 70); 

for(int i = 0; i < 5; i++) 
{ 
	user2.AddScore(Random.Next(100)); 
}
User user3 = new User();
user3.Name = "Zbyszek"; 
user3.Surname = "Śmigło"; 
user3.Age = Random.Next(18, 70); 

for(int i = 0; i < 5; i++)
{
	user3.AddScore(Random.Next(100)); 
} 

List<int> result = new List<int>(); 
result.Add(user1.Result); 
result.Add(user2.Result); 
result.Add(user3.Result);

int maxResult = result.Max();

if(maxResult == user1.Result) 
{
	user1.ShowFullEployerData();
}
else if (maxResult == user2.Result)
{
	user2.ShowFullEployerData();
}
else if (maxResult == user3.Result)
{
	user3.ShowFullEployerData();
}
Console.ReadKey();
