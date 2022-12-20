using AppTransaction.Core;
using AppTransaction.Service;
using AppTransaction.SharedModels;

namespace AppTransaction;
internal class Program
{
    static void Main(string[] args)
    {
        ApplicationTransaction applicationTransaction = new ApplicationTransaction();
        applicationTransaction.SignIn();
    }
}
