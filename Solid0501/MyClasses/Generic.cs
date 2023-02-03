namespace AbonentOBD;
public class OutClass<T> where T:struct
{
    private T PropertyT;
    // private K PropertyK;
    // private int v1;
    // private string v2;

    public OutClass(T propertyT) //, K propertyK
    {
        // if (propertyT == null) throw new ArgumentNullException(nameof(propertyT));
        // if (propertyK == null) throw new ArgumentNullException(nameof(propertyK));
        PropertyT = propertyT;
        // PropertyK = propertyK;
    }

    // public OutClass(int v1, string v2)
    // {
    //     this.v1 = v1;
    //     this.v2 = v2;
    // }

    public T GetPropertyT()
    {
        return PropertyT;
    }
    public void SetPropertyT(T propertyT)
    {
        PropertyT = propertyT;
    }
    // public K GetPropertyK()
    // {
    //     return PropertyK;
    // }
    // public void SetPropertyK(K propertyK)
    // {
    //     PropertyK = propertyK;
    // }

    public void Show()
    {
        System.Console.WriteLine($"{PropertyT.ToString()} ");
    }

}