using System;
using System.Collections.Generic;
using System.Linq;

namespace examen
{
    class Notebook
    {
        List<Student> students = new List<Student>(); //список который содержит всех студентов Все методы связаны с методами листов
        public void AddStudent(string name, string surname, string birthday, int telephone)
        {
            students.Add(new Student(name, surname, birthday, telephone));
        }
        public void Delete()
        {
            Console.WriteLine("select the number in the list of the student you want to delete");
            int n = int.Parse(Console.ReadLine());
            students.RemoveAt(n);
        }
        public void ShowStudents()
        {
            foreach(Student student in students)
            {
                Console.WriteLine(student.Name + " " + student.Surname + " " + student.Birthday + " " + student.TelephoneNumber.ToString());
            }
        }
        public void SortByFamily()
        {
            IEnumerable<Student> inOrder = from person in students orderby person.Surname select person;
            foreach (Student student in inOrder)
            {
                Console.WriteLine(student.Name + " " + student.Surname + " " + student.Birthday + " " + student.TelephoneNumber.ToString());
            }

        }
        public void FindByNumber()
        {
            Console.WriteLine("please write the number of hte student you want: ");
            int number = int.Parse(Console.ReadLine());
            foreach(Student student in students)
            {
                if(student.TelephoneNumber == number)
                {
                    Console.WriteLine(student.Name + " " + student.Surname + " " + student.Birthday + " " + student.TelephoneNumber.ToString());
                }
            }
        }
    }
    class Student   //создаём класс который содержит все характеристики студентов
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public int TelephoneNumber { get; set; }
        public Student(string name, string surname, string birthday, int telephone)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            TelephoneNumber = telephone;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook myNote = new Notebook();
            myNote.AddStudent("Mengli", "Gapurova", "06.06.1999", 9184756);
            myNote.AddStudent("Renata", "Ingurova", "17.12.1999", 8796542);
            myNote.AddStudent("Vladimir", "Lenin", "12.04.1870", 9863257);
            myNote.AddStudent("Ivan", "Ivanov", "06.08.1999", 548962147);
            Console.WriteLine("current list:");
            myNote.ShowStudents();
            Console.WriteLine("sorted by surname:");
            myNote.SortByFamily();
            myNote.FindByNumber();
        }
    }
}
