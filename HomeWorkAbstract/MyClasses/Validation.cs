namespace Myclasses;

public abstract class Validation
{

    public abstract bool IsValidId(string text);
    public abstract bool IsValidEmail(string text);
    public abstract bool IsValidPwd();

}