using System.Text.RegularExpressions;
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

    public override bool IsValidEmail(string text)
    {
        if (text.Contains('@') && (text.EndsWith(".com") || text.EndsWith(".by")))
        {
            return true;
        }
        return false;
    }

    public override bool IsValidPwd(string text, string text1)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != text1[i])
            {
                return false;
            }
        }
        return true;
    }
}