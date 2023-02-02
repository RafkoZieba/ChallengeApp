using ChallengeApp;

Random Random = new Random();

Employee employer1 = new Employee(); 
employer1.Name = "Jacek"; 
employer1.Surname = "Kowalski"; 
employer1.Age = Random.Next(18, 70); 

for(int i = 0; i < 5; i++) 
{ 
	employer1.AddScore(Random.Next(100)); 
}
Employee employer2 = new Employee(); 
employer2.Name = "Michal"; 
employer2.Surname = "Zawadzki"; 
employer2.Age = Random.Next(18, 70); 

for(int i = 0; i < 5; i++) 
{ 
	employer2.AddScore(Random.Next(100)); 
}
Employee employer3 = new Employee();
employer3.Name = "Zbyszek"; 
employer3.Surname = "Śmigło"; 
employer3.Age = Random.Next(18, 70); 

for(int i = 0; i < 5; i++)
{
	employer3.AddScore(Random.Next(100)); 
} 

List<int> result = new List<int>(); 
result.Add(employer1.Result); 
result.Add(employer2.Result); 
result.Add(employer3.Result);

int maxResult = result.Max();

if(maxResult == employer1.Result) 
{
	employer1.ShowFullEployerData();
}
else if (maxResult == employer2.Result)
{
	employer2.ShowFullEployerData();
}
else if (maxResult == employer3.Result)
{
	employer3.ShowFullEployerData();
}
Console.ReadKey();
