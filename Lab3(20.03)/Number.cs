using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_20._03_
{
    internal class Number
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        /// <summary>
        /// Default
        /// </summary>
        public Number()
        {
            Num1 = 0;
            Num2 = 0;
        }
        /// <summary>
        /// With input parameters
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public Number(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public double Sum()
        {
            return Num1 + Num2;
        }
        public double Difference()
        { 
            return Num1 - Num2;
        }
        public double Product()
        {
            return Num1 * Num2;
        }
        public double Division()
        {
            if (Num2 != 0)
            {
                return (Num1 / Num2);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
        }
        public double Remainder()
        {
            return Num1 % Num2;
        }
        public bool Compare(Number otherNumber)
        {
            return Sum() == otherNumber.Sum();
        }

        public void SaveToJson(string filename)
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(filename, json);
            Console.WriteLine("Object saved to JSON file: " + filename);
        }

        public static Number LoadFromJson(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("JSON file does not exist.");
                return null;
            }

            string json = File.ReadAllText(filename);
            Number number = JsonConvert.DeserializeObject<Number>(json);
            Console.WriteLine("Object loaded from JSON file: " + filename);
            return number;
        }
        ~Number()
        {
            Console.WriteLine("The object has been deleted");
        }
    }
}
