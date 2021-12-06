using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Laba
{
    class Student
    {
        public int id { get; private set; }
        public string firstname;
        public string surname;
        public string secondname;
        public int bornyear;
        public string address;
        public string phone;
        public string faculty;
        public byte course;

        public Student(string newSecondname = "null", string newFirstname = "null", string newSurname = "null")
        {
            surname = newSurname;
            firstname = newFirstname;
            secondname = newSecondname;
            address = "null";
            bornyear = 0;
            phone = "null";
            faculty = "null";
            course = 0;
            id = GetHashCode();
        }

        public Student(
            string newSecondname,
            string newFirstname,
            string newSurname,
            int newBornyear,
            string newAdress,
            string newPhone,
            string newFaculty,
            byte newCourse
            )
        {
            surname = newSurname;
            firstname = newFirstname;
            secondname = newSecondname;
            address = newAdress;
            bornyear = newBornyear;
            phone = newPhone;
            faculty = newFaculty;
            course = newCourse;
            id = GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Student st = obj as Student;
            if (this.course == st.course) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.firstname + this.secondname;
        }
    }

    class University
    {
        private const int MAX_STUDENTS = 256;
        private int studentsCount = 0;
        static Student[] students = new Student[MAX_STUDENTS];

        public void AddStudent(Student s)
        {
            if (s is null) throw new Exception("Вы не можете добавить пустой объект");

            students[studentsCount] = s; // закидываем в массив студента
            studentsCount++;
        }

        public void ShowStudentsList()
        {
            Console.WriteLine("Список стуентов:\n");
            for (int i = 0; i < studentsCount; i++)
            {
                Student s = students[i];
                Console.WriteLine(info(s));
            }
        }

        public void ShowStudentsList(string faculty)
        {
            int count = 0;
            Console.WriteLine($"Студенты факультета: {faculty}\n");
            for (int i = 0; i < studentsCount; i++)
            {
                if (students[i].faculty == faculty)
                {
                    Console.WriteLine(info(students[i]));
                    count++;
                }
            }

            if (count == 0) Console.WriteLine($"Студентов с факультета {faculty} в списке нет");
            else Console.WriteLine($"Общее количество студентов с факультета {faculty}: {count}");
        }

        static string info(Student s)
        {
            return $"ID: {s.id}\n" +
                    $"Имя: {s.firstname}\n" +
                    $"Фамилия: {s.secondname}\n" +
                    $"Отчество: {s.surname}\n" +
                    $"Год рождения: {s.bornyear}\n" +
                    $"Факультет: {s.faculty}\n" +
                    $"Курс: {s.course}\n" +
                    $"Телефон: {s.phone}\n" +
                    $"Адресс: {s.address}\n" +
                    $"--------------------\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student vova = new Student();


            Student Kirill = new Student("Булавский", "Кирилл", "Сергеевич", 2002, "Витебск", "375291233232", "FIT", 2);
            Student Student1 = new Student("Хлыстов", "Глеб", "Георгиевич", 2002, "Любань", "375291245", "FIT", 2);
            Student Student2 = new Student("Дикун", "Игорь", "Вячеславович", 2002, "Светлогорск", "37544533232", "FIT", 2);
            Student Student3 = new Student("Андреев ", "Андрей", "Андреич", 2002, "Минск", "375291233232", "FIT", 2);
            Student Student4 = new Student("Пупкин ", "Акакий", "Акакиевич", 2002, "Таганрок", "375291233232", "TOV", 2);

            University BSTU = new University();
            BSTU.AddStudent(Kirill);
            BSTU.AddStudent(Student1);
            BSTU.AddStudent(Student2);
            BSTU.AddStudent(Student3);

            University BGU = new University();
            BGU.AddStudent(Student4);

            BSTU.ShowStudentsList("FIT");
           // BSTU.ShowStudentsList("TOV");
        }
    }
}