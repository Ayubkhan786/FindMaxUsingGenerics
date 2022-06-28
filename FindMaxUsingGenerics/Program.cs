using FindMaxUsingGenerics;

Console.WriteLine("Find Maximum , Problems using Generics");


Random random = new Random();   
random.Next(0,100);
int X= random.Next(0, 100);
int Y= random.Next(0, 100);
int Z= random.Next(0, 100);

Console.WriteLine(X);
Console.WriteLine(Y);
Console.WriteLine(Z);

Find<int> max = new Find<int>();
max.Compare(X,Y,Z);