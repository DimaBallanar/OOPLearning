namespace Myclasses;

public abstract class Validation
{

    public abstract bool IsValidId(string text);
    public abstract bool IsValidEmail();
    public abstract bool IsValidPwd();

}