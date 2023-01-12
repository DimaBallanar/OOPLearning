namespace Time;

public class SetTime
{
    private int _hours;
    private int _minutes;
    private int _seconds;
    DateTime Time = DateTime.Now;

    public int Hours
    {
        get { return _hours > 0 && _hours < 24 ? _hours : 00; }
        set { _hours = value; }
    }
    public int Minutes
    {
        get { return _minutes > 0 && _minutes < 60 ? _minutes : 00; }
        set { _minutes = value; }
    }
    public int Seconds
    {
        get { return _seconds > 0 && _seconds < 60 ? _seconds : 00; }
        set { _seconds = value; }
    }

    public void ChangeH(int hours)
    {
        Time=Time.AddHours(hours);
    }
    public void ChangeM(int minutes)
    {        
       Time= Time.AddMinutes(minutes);    

    }

    public void ChangeS(int seconds)
    {       
        Time=Time.AddSeconds(seconds);
       
    }  

    public void ToPrint()
    {
        System.Console.WriteLine($"{Time}");
    }




}