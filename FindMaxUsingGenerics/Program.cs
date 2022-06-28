using FindMaxUsingGenerics;

Console.WriteLine("Find Maximum , Problems using Generics");

//To CompareInt
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





//To CompareFloat

float A=(2.64875F);
float B=(0.34574F);
float C=(1.54674231F);


Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);


Find<float> maxFloat = new Find<float>();
maxFloat.CompareFloat(A, B, C);
