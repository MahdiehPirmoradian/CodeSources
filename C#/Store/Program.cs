// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Customer
{
    private int _id;
    private string _name;
    private DateTime _birthdate;
    private string _email;
    private string _phone;
    private string _address;
    private string _zipcode;


    public List<Order> Orders = new List<Order>();

    public Customer(int id) 
    {
            this._id = id;
    }

    public Customer(int id, string name) 
      : this(id) 
    {
        this._name = name;
    }

    public class Order
    { }
    
}
