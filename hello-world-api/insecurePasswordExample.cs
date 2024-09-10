using System;

namespace hello_world_api
{
    public class InsecurePasswordExample
    {
        public static void ShowPasswordVulnerabilities()
        {
            // Hard-coded password (bad practice)
            string password = "P@ssw0rd123";

            // Storing password in plain text (bad practice)
            Console.WriteLine("Your password is: " + password);

            // Simulating password usage
            if (password == "P@ssw0rd123")
            {
                Console.WriteLine("Access granted.");
            }
            else
            {
                Console.WriteLine("Access denied.");
            }
        }
    }
}
