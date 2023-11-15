// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var customer1 = new Customer();
var customer = new Customer(1, "Sebastian", "Frankfurt");

var order = new Order();
customer.Orders.Add(order);

var calculator = new Calculator();
 
var result = calculator.Add(new int[] {1, 2, 3} );
var a = 2;
var b = 0;

b = calculator.Add1(a);

string Name = "Ali";

Console.WriteLine("Hello.....!" + Name + "  " +  result + " point is at ({0} , {1})");
