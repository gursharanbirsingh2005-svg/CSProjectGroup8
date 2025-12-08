using System;

namespace PatientClinicalDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Patient Clinical Details Program ===");
            Console.WriteLine();

            // Create first patient
            Patient p1 = new Patient();
            p1.FirstName = "Mark";
            p1.LastName  = "Taylor";
            p1.Age       = 35;
            p1.Address   = "123 Main Street";
            p1.Height    = 178;    // cm
            p1.Weight    = 82;     // kg

            Console.WriteLine("Patient #1:");
            p1.PrintFullName();
            Console.WriteLine("Age: " + p1.Age);
            Console.WriteLine("Address: " + p1.Address);
            Console.WriteLine("Height: " + p1.Height + " cm");
            Console.WriteLine("Weight: " + p1.Weight + " kg");
            Console.WriteLine();

            // BMI calculation
            p1.UseAnyName();

            // Blood pressure check
            p1.CheckBloodPressure(122, 85);
            Console.WriteLine();

            // --------------------------------
            // Second patient (optional but good for understanding)
            // --------------------------------
            Patient p2 = new Patient();
            p2.FirstName = "Aggie";
            p2.LastName  = "Smith";
            p2.Age       = 29;
            p2.Address   = "10 Hillwood Ave";
            p2.Height    = 160;
            p2.Weight    = 60;

            Console.WriteLine("Patient #2:");
            p2.PrintFullName();
            Console.WriteLine("Age: " + p2.Age);
            Console.WriteLine("Address: " + p2.Address);
            Console.WriteLine("Height: " + p2.Height + " cm");
            Console.WriteLine("Weight: " + p2.Weight + " kg");
            Console.WriteLine();

            p2.UseAnyName();
            p2.CheckBloodPressure(138, 90);

            Console.WriteLine("\nProgram complete. Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
