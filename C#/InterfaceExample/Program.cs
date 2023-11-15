// See https://aka.ms/new-console-template for more information

using InterfaceExample;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

int[] data = {3,1,2 };

Class1 class1 = new Class1();
class1.Train(data);

string filepath = @"C:\Exercise\test.txt";
//class1.Save(filepath);
class1.Load(filepath);


Class2 class2= new Class2();
class2.Train(data);
Console.WriteLine($"Average of the trained data is:  ");
