using AppTransaction.Core;

namespace AppTransaction;
internal class Program
{
    static void Main(string[] args)
    {
        ApplicationTransaction applicationTransaction = new ApplicationTransaction();
        applicationTransaction.SignIn();
    }
}
