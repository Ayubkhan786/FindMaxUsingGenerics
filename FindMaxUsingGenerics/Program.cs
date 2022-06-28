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
Max.Compare();

SingleGenericMethod<string> Max1 = new SingleGenericMethod<string>("Apple", "Peach", "banana");
Max1.Compare();

SingleGenericMethod<float> Max2 = new SingleGenericMethod<float>(0.002502F, 1.25001F, 2.5401F);
Max2.Compare();





//To Extend the Parameters

int[] val = new int[5] { 1,5,6,8,9 };
Exp<int> maxi = new Exp<int>(val);
maxi.sort();
maxi.Comparison();
maxi.Show();
Console.WriteLine("The Max val is :" + maxi.Comparison());
Console.WriteLine("--------------------------------------------------------------------------------");


string[] val1 = new string[4] {"Apple","Banana","Fruit","Peach"  };
Exp<string> maxi1 = new Exp<string>(val1);
maxi1.sort();
maxi1.Comparison();
maxi1.Show();
Console.WriteLine("The Max val is :" + maxi1.Comparison());
Console.WriteLine("--------------------------------------------------------------------------------");



float[] val2 = new float[5] { 1.54502F, 0.8445103F, 1.745105F, 1.087648F, 1.78848F };
Exp<float> maxi2 = new Exp<float>(val2);
maxi2.sort();
maxi2.Comparison();
maxi2.Show();
Console.WriteLine("The Max val is :" + maxi2.Comparison());
Console.WriteLine("--------------------------------------------------------------------------------");

