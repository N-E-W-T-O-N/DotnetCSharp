using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace Program
{
    public class LinearRegression
    {
        public static void Main(String[] args)
        {
            List<SalaryData> users = new();
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };
            using var st = new StreamReader("Salary_Data.csv");
            using (var csv = new CsvReader(st, csvConfig))
            {
                users = csv.GetRecords<SalaryData>().ToList();
            }
                //Or You can Iterate over it
            /* while (csv.Read())
             {
                 Console.WriteLine(csv.GetField(0) + " "+csv.GetField(1));
             }*/
            float sum = 0.0f;
            foreach (var user in users)
            {
                Console.WriteLine(user.Salary + " " + user.YearsExperience);

                sum += (float)user.Salary;
            }

            //Write in CSV File
            var newData = new List<SalaryData>() { new SalaryData {Salary = 12134.23M ,YearsExperience =6.5M } };
            using (var stream = File.Open("filePersons.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(newData);
            }


        }
    }

    public class SalaryData
    {
        public decimal YearsExperience { get; set; }
        public decimal Salary{get;set; }
    }
}