using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVCR1.Models
{
    public enum AccountType
    {
        Checking,
        Deposit
    }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
        public override string ToString()
        {
            string res = $"Номер счета {accNo}, баланс {accBal}, тип {accType}";
            return res;
        }
    }
    public class StudyCSharp
    {
        public static string SetStatus(int age)
        {
            string status = "junior developer";
            if ((age > 2) && (age < 7)) status = "middle developer";
            else if ((age >= 7) && (age < 15)) status = "senior developer";
            else if ((age >= 15)) status = "sensei";
            return status;
        }
    }
    public class Triangle
    {
        public double Sta { get; set; }
        public double Stb { get; set; }
        public double Stc { get; set; }
        public double Perimeter => Math.Round(Sta + Stb + Stc);
        public string Name => $"\"Треугольник со сторонами {Sta},{Stb} и {Stc}\"";
        public double Area
        {
            get
            {
                double sq = Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - Sta) * (Perimeter / 2 - Stb) * (Perimeter / 2 - Stc));
                return sq;
            }
        }
        public Triangle(double a, double b, double c)
        { 
            Sta = a; 
            Stb = b;
            Stc = c; 
        }
    }
}

