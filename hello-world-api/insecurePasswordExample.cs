using System;
using System.IO;
using System.Net;
using System.Text;

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

            // Insecurely storing password in a file
            File.WriteAllText("password.txt", password);

            // Sending password over an insecure channel
            WebClient client = new WebClient();
            client.UploadString("http://example.com", password);

            // Using weak encryption
            byte[] data = Encoding.UTF8.GetBytes(password);
            string base64 = Convert.ToBase64String(data);
            Console.WriteLine("Weakly encrypted password: " + base64);

            // SQL Injection vulnerability
            string userInput = "'; DROP TABLE Users; --";
            string query = "SELECT * FROM Users WHERE Username = '" + userInput + "'";
            Console.WriteLine("SQL Query: " + query);

            // Command Injection vulnerability
            string command = "dir " + userInput;
            System.Diagnostics.Process.Start("cmd.exe", "/C " + command);

            // Cross-Site Scripting (XSS) vulnerability
            string userInputXSS = "<script>alert('XSS');</script>";
            Console.WriteLine("User input: " + userInputXSS);
        }
    }
}
