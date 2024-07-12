using System;
using System.Collections.Generic;

namespace HealthCareManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Health Care Management System");
                Console.WriteLine("1. Add New Patient");
                Console.WriteLine("2. View Patient Information");
                Console.WriteLine("3. List All Patients");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddNewPatient(patients);
                        break;
                    case 2:
                        ViewPatientInformation(patients);
                        break;
                    case 3:
                        ListAllPatients(patients);
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        static void AddNewPatient(List<Patient> patients)
        {
            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Patient Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Patient Condition: ");
            string condition = Console.ReadLine();

            Patient newPatient = new Patient(name, age, condition);
            patients.Add(newPatient);

            Console.WriteLine("Patient added successfully.");
        }

        static void ViewPatientInformation(List<Patient> patients)
        {
            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            foreach (Patient patient in patients)
            {
                if (patient.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Name: {patient.Name}");
                    Console.WriteLine($"Age: {patient.Age}");
                    Console.WriteLine($"Condition: {patient.Condition}");
                    return;
                }
            }

            Console.WriteLine("Patient not found.");
        }

        static void ListAllPatients(List<Patient> patients)
        {
            Console.WriteLine("List of All Patients:");
            foreach (Patient patient in patients)
            {
                Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}, Condition: {patient.Condition}");
            }
        }
    }

    class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Condition { get; set; }

        public Patient(string name, int age, string condition)
        {
            Name = name;
            Age = age;
            Condition = condition;
        }
    }
}
