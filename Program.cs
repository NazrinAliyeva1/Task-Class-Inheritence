using System;

namespace Class__Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student nermin = new Student("Nezrin", "Aliyeva", "AB106", 70);
            Student sehla = new Student("Sehla", "Ceferli", "AB132", 45);
            Student aynur = new Student("Aynur", "Zulfugarzade", "AB107", 89);
            Student cavid = new Student("Cavid", "Cabbarli", "AB102", 60);
            Student aytac = new Student("Aytac", "Verdiyeva", "AB104", 95);

            Student[] stds = {nermin, sehla, aynur, cavid, aytac};
            foreach (Student student in stds)
            {
                student.Getİnfo();
                student.CheckGraduation();
                student.GetDiplomDegree();
            }
        }
    }

    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool isGraduated;

        public Student(string name, string surname, string group, int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            isGraduated = CalcIsGreated();
        }
        public bool CalcIsGreated()
        {
            return Point >= 65;
        }

        public void Getİnfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point}, {(isGraduated ? "" : "")}");
        }
        public void CheckGraduation()
        {
            if (isGraduated)
            {
                Console.WriteLine($"{Name} mezun oldu.");
            }
            else
            {
                Console.WriteLine($"{Name} mezun olmadi.");
            }
        }
        public void GetDiplomDegree()
        {
            if (Point <= 65)
            {
                Console.WriteLine("Diplom novu: Yoxdur");
            }
            else if (Point >= 65 && Point <= 80)
            {
                Console.WriteLine("Diplom novu: Adi");
            }
            else if (Point >= 81 && Point <= 90)
            {
                Console.WriteLine("Diplom novu: Seref");
            }
            else
            {
                Console.WriteLine("Diplom novu: Yuksek seref");
            }
        }

    }

}


