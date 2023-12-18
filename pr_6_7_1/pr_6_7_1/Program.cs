using System;

namespace pr_6_7_1
{
    class Student
    {
        private string lastName;
        // Фамилия студента
        private string firstName;
        // Имя студента
        private int academicYear;
        // Курс студента
        private int studentAge;
        // Возраст студента

        public string LastName
        {
            get { return (lastName != "") ? lastName : "неизвестная"; }
            // Возвращает фамилию студента, если она задана; иначе "неизвестная"
            set { lastName = value.ToUpper(); }
            // Преобразует фамилию в верхний регистр и сохраняет
        }

        public string FirstName
        {
            get { return (firstName != "") ? firstName : "неизвестное"; }
            // Возвращает имя студента, если оно задано; иначе "неизвестное"
            set { firstName = value; }
            // Сохраняет имя студента
        }

        public int AcademicYear
        {
            get => academicYear;
            // Возвращает курс студента
            set { academicYear = (value < 1 || value > 4) ? 0 : value; }
            // Проверяет, находится ли курс в допустимом диапазоне (1-4); иначе задает значение 0
        }

        public int StudentAge
        {
            get => studentAge;
            // Возвращает возраст студента
            set { studentAge = (value < 15 || value > 35) ? 0 : value; }
            // Проверяет, находится ли возраст в допустимом диапазоне (15-35); иначе задает значение 0
        }

        public Student(string lastName, string firstName, int academicYear, int studentAge)
        {
            this.LastName = lastName;
            // Задает фамилию студента
            this.FirstName = firstName;
            // Задает имя студента
            this.AcademicYear = academicYear;
            // Задает курс студента
            this.StudentAge = studentAge;
            // Задает возраст студента
        }

        public void ShowInfo()
        {
            Console.WriteLine("Студент {0} {1} курса {2} возраста {3}", LastName, FirstName, AcademicYear, StudentAge);
            // Выводит информацию о студенте - фамилию, имя, курс и возраст
        }
    }

    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Иванов", " ", 3, 20);
            // Создаем экземпляр класса Student и передаем значения для инициализации
            student1.ShowInfo();
            // Выводим информацию о студенте

            Student student2 = new Student("", "", 4, 35);
            // Создаем другой экземпляр класса Student и передаем значения для инициализации
            student2.ShowInfo();
            // Выводим информацию о студенте

            Student student3 = new Student("Петров", "Пётр", -7, 120);
            // Создаем еще один экземпляр класса Student и передаем значения для инициализации
            student3.ShowInfo();
            // Выводим информацию о студенте
        }
    }
}
