    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    namespace Doctor_Reassesment1
    {
        public class Doctor
        {
            public string RegistrationNo { get; set; }
            public string DoctorName { get; set; }
            public string City { get; set; }
            public string Specialization { get; set; }
            public string ClinicAddress { get; set; }
            public string ClinicTimings { get; set; }
            public string ContactNo { get; set; }

            // Constructor to initialize Doctor object
            public Doctor(string regNo, string drName, string city, string specialization,
                          string clinicAddress, string clinicTimings, string contactNo)
            {
                RegistrationNo = regNo;
                DoctorName = drName;
                City = city;
                Specialization = specialization;
                ClinicAddress = clinicAddress;
                ClinicTimings = clinicTimings;
                ContactNo = contactNo;
            }
        }

        class Program
        {
            static List<Doctor> doctors = new List<Doctor>();

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("\nDoctor Management System");
                    Console.WriteLine("1. Add Doctor Information");
                    Console.WriteLine("2. Search Doctor by Registration No");
                    Console.WriteLine("3. Exit");

                    Console.Write("Select an option: ");
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            AddDoctor();
                            break;
                        case "2":
                            SearchDoctor();
                            break;
                        case "3":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }

            static void AddDoctor()
            {
                Console.WriteLine("\nEnter Doctor Information:");
                string registrationNo;
                do
                {
                    Console.Write("Registration No (7 digits): ");
                    registrationNo = Console.ReadLine();
                } while (!ValidateRegistrationNo(registrationNo));

                
                string doctorName;
                do
                {
                    Console.Write("Doctor Name (Alphabets only): ");
                    doctorName = Console.ReadLine();
                } while (!ValidateAlphabets(doctorName));

                
                string city;
                do
                {
                    Console.Write("City (Alphabets only): ");
                    city = Console.ReadLine();
                } while (!ValidateAlphabets(city));

                
                string specialization;
                do
                {
                    Console.Write("Area of Specialization (Alphabets only): ");
                    specialization = Console.ReadLine();
                } while (!ValidateAlphabets(specialization));

                Console.Write("Clinic Address: ");
                string clinicAddress = Console.ReadLine();

                
                Console.Write("Clinic Timings: ");
                string clinicTimings = Console.ReadLine();

                
                string contactNo;
                do
                {
                    Console.Write("Contact No (10 digits): ");
                    contactNo = Console.ReadLine();
                } while (!ValidateContactNo(contactNo));

               
                doctors.Add(new Doctor(registrationNo, doctorName, city, specialization, clinicAddress, clinicTimings, contactNo));
                Console.WriteLine("\nDoctor information added successfully!");
            }

            
            static void SearchDoctor()
            {
                Console.Write("\nEnter Registration No to search: ");
                string registrationNo = Console.ReadLine();

                Doctor foundDoctor = doctors.Find(doc => doc.RegistrationNo == registrationNo);

                if (foundDoctor != null)
                {
                    Console.WriteLine($"\nDoctor Found:\n" +
                                      $"Registration No: {foundDoctor.RegistrationNo}\n" +
                                      $"Name: {foundDoctor.DoctorName}\n" +
                                      $"City: {foundDoctor.City}\n" +
                                      $"Specialization: {foundDoctor.Specialization}\n" +
                                      $"Clinic Address: {foundDoctor.ClinicAddress}\n" +
                                      $"Clinic Timings: {foundDoctor.ClinicTimings}\n" +
                                      $"Contact No: {foundDoctor.ContactNo}");
                }
                else
                {
                    Console.WriteLine("Doctor with the provided Registration No not found.");
                }
            }

            
            static bool ValidateRegistrationNo(string registrationNo)
            {
                if (Regex.IsMatch(registrationNo, @"^\d{7}$"))
                    return true;

                Console.WriteLine("Invalid Registration No. It should be exactly 7 digits.");
                return false;
            }

            
            static bool ValidateAlphabets(string input)
            {
                if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
                    return true;

                Console.WriteLine("Invalid input. Only alphabets are allowed.");
                return false;
            }

            
            static bool ValidateContactNo(string contactNo)
            {
                if (Regex.IsMatch(contactNo, @"^\d{10}$"))
                    return true;

                Console.WriteLine("Invalid Contact No. It should be exactly 10 digits.");
                return false;
            }
        }
    }
