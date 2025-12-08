using System;

namespace PatientClinicalDetails
{
    public class Patient
    {
        // -----------------------
        // Properties
        // -----------------------

        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        // Required properties
        public int Height { get; set; }   // height in cm
        public int Weight { get; set; }   // weight in kg

        // -----------------------
        // Methods
        // -----------------------

        // Check Blood Pressure Method
        public void CheckBloodPressure(int systolic, int diastolic)
        {
            if (systolic <= 120 && diastolic <= 80)
            {
                Console.WriteLine("Normal Blood Pressure");
            }
            else if (systolic <= 129 && diastolic <= 80)
            {
                Console.WriteLine("Elevated Blood Pressure");
            }
            else if (systolic <= 139 && diastolic <= 89)
            {
                Console.WriteLine("Stage 1 Hypertension");
            }
            else if (systolic >= 140 && diastolic >= 90 && systolic < 180 && diastolic < 120)
            {
                Console.WriteLine("Stage 2 Hypertension");
            }
            else if (systolic >= 180 && diastolic >= 120)
            {
                Console.WriteLine("Hypertensive Crisis");
            }
            else
            {
                Console.WriteLine("Blood Pressure Out of Expected Range");
            }
        }

        // Prints full name
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        // -----------------------
        // BMI Calculation Method
        // -----------------------
        public void UseAnyName()
        {
            double heightInMeters = Height / 100.0;
            double weightInKg     = Weight;

            if (heightInMeters <= 0 || weightInKg <= 0)
            {
                Console.WriteLine("Error: Height and Weight must be greater than zero.");
                return;
            }

            double bmi = weightInKg / (heightInMeters * heightInMeters);

            Console.WriteLine("BMI Value: " + bmi.ToString("F1"));

            if (bmi < 18.5)
            {
                Console.WriteLine("BMI Status: Underweight");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("BMI Status: Normal Weight");
            }
            else if (bmi >= 25.0 && bmi <= 29.9)
            {
                Console.WriteLine("BMI Status: Overweight");
            }
            else
            {
                Console.WriteLine("BMI Status: Obese");
            }

            Console.WriteLine();
        }

    } // class
} // namespace
