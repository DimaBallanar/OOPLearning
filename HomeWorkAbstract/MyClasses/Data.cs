namespace Myclasses;

public class Data : Validation
{
    public override bool IsValidId(string text)
    {
        if (int.TryParse(text, out int num))
        {
            return true;
        }
        return false;
    }

    public override bool IsValidEmail()
    {
        throw new NotImplementedException();
    }

    public override bool IsValidPwd()
    {
        throw new NotImplementedException();
    }
}