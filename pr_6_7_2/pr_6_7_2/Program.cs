using System;

namespace pr_6_7_2
{
    class Employee
    {
        private string lastName;
        // Фамилия сотрудника
        private int age;
        // Возраст сотрудника
        private string position;
        // Должность сотрудника
        private int experience;
        // Опыт работы сотрудника

        public int Age { get => age; set { age = (value < 16 || value > 60) ? 0 : value; } }
        // Возраст сотрудника с проверкой на допустимый диапазон
        public int Experience { get => experience; set { experience = (value < 0 || value > 45) ? 0 : value; } }
        // Опыт работы сотрудника с проверкой на допустимый диапазон

        public Employee(string lastName, int age, string position, int experience)
        {
            this.lastName = lastName;
            // Задаем фамилию сотрудника
            this.Age = age;
            // Задаем возраст сотрудника
            this.position = position;
            // Задаем должность сотрудника
            this.Experience = experience;
            // Задаем опыт работы сотрудника
        }
        public void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2} {3}", lastName, Age, position, Experience);
            // Выводим информацию о сотруднике (фамилия, возраст, должность, опыт работы)
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee("Федоров", 25, "Менеджер", 5);
            // Создаем экземпляр класса Employee и передаем значения для инициализации
            emp1.ShowInfo();
            // Выводим информацию о сотруднике
        }
    }
}

