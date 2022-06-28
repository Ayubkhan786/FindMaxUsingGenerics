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




//To Compare String
Find<string> maxString = new Find<string>();
maxString.CompareString("Mohamed", "Abdul", "Ayub");






//To CompareAll at Once
SingleGenericMethod<int> Max = new SingleGenericMethod<int>(425, 874, 545);
max.Compare(425, 874, 545);

SingleGenericMethod<string> Max1 = new SingleGenericMethod<string>("Apple", "Peach", "banana");
Max1.Compare();

SingleGenericMethod<float> Max2 = new SingleGenericMethod<float>(0.002502F, 1.25001F, 2.5401F);
Max2.Compare();

