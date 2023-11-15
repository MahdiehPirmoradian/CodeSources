// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;

public class Customer 
{
    public int Id;
    public string Name;
    public string Address;
    public List<Order> Orders;


    public string FName { get; set; }

    //default & Parameterless Constructor
    public Customer()
    {
        Orders = new List<Order>();
    }

    //Overloading Constructor
    public Customer(int id) 
        : this()
    { 
        this.Id = id;
    }



    public Customer(int id, string name, string address)
        : this(id)
    {
        Name = name;
        Address = address;
    }
}
