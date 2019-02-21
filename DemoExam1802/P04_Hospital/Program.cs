using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<String>> departmentPatients = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> doctorPatient = new Dictionary<string, List<string>>();


            while (true)
            {
                var splittedInput = Console.ReadLine().Split(" ");

                if (splittedInput[0] == "Output")
                {
                    break;
                }

                var department = splittedInput[0];
                var doctor = splittedInput[1] + " " + splittedInput[2];
                var patient = splittedInput[3];

                if (!departmentPatients.ContainsKey(department))
                {
                    departmentPatients[department] = new List<string>();
                }

                if (!doctorPatient.ContainsKey(doctor))
                {
                    doctorPatient[doctor] = new List<string>();
                }

                departmentPatients[department].Add(patient);
                doctorPatient[doctor].Add(patient);
            }


            while (true)
            {
                var splittedInput = Console.ReadLine().Split(" ");

                if (splittedInput[0] == "End")
                {
                    break;
                }

                if (departmentPatients.ContainsKey(splittedInput[0]) && splittedInput.Length == 1)
                {
                    Console.WriteLine(string.Join(System.Environment.NewLine, departmentPatients[splittedInput[0]]));
                }
                else if (departmentPatients.ContainsKey(splittedInput[0]) && splittedInput.Length == 2)
                {
                    var room = int.Parse(splittedInput[1]);
                    var allPatiantsInDepartment = departmentPatients[splittedInput[0]];
                    allPatiantsInDepartment.Skip((room - 1) * 3).Take(3).OrderBy(x => x).ToList().ForEach(Console.WriteLine);
                }
                else
                {
                    var doctor = splittedInput[0] + " " + splittedInput[1];
                    foreach (var patient in doctorPatient[doctor].OrderBy(x => x))
                    {
                        Console.WriteLine(patient);
                    }
                }
            }
        }
    }
}
