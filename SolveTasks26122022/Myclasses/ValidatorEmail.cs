

namespace ValidatorE
{

    public class ValidatorEmail
    {
        public bool CheckEmail(string text)
        {
            int countSobak = 0;
            foreach (char a in text)
            {
                if (a == '@' && countSobak < 2)
                {
                    countSobak += 1;
                }
                else
                {
                    return false;
                }
            }
            string[] massiv = text.Split('@');
            string myCheck = massiv[1];
            string[] result = myCheck.Split('.');
            if (result.Length == 2 && result[1].Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

