namespace MyClasses.Cars;

public class Car : MyClasses.Transport.Transport
{

    public Car()
    {

    }
    public int Type { get; set; }
    private string _name;
    public override string Name
    {
        get { return !string.IsNullOrEmpty(_name) ? _name : "Our Car"; }
        set { _name = value; }
    }

    public void Moving()
    {
        System.Console.WriteLine($"Car '{Name}' moving");
    }

    public void Stoping()
    {
        System.Console.WriteLine("Car Stopping");
    }

    public Car(double spead, string name, int type) : base(spead, name)
    {
        Type = type;
    }
    public Car(string name, int type) : base(name)
    {
        Type = type;
    }
    public Car(string name) : base(name)
    {

    }

    public void Drift()
    {
        System.Console.WriteLine($"{Name} is break");
    }
    public override string ToString()
    {
        return $"{Name}, {Spead}, {Type}";
    }

}