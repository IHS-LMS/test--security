using System;
using System.Security.Permissions;
using System.Security.Principal;

namespace test__security
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            PrincipalPermission principalPerm = new PrincipalPermission(null, "Administrators");
            principalPerm.Demand();
            Console.WriteLine("Demand succeeded..");
            Console.Read();
        }
    }
}
