namespace zad_26
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();

            Console.Write("n=");
            int n = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < n; i++)
            {
                Console.Write("First name: ");
                string firstName = Console.ReadLine()!;

                Console.Write("Last name: ");
                string lastName = Console.ReadLine()!;

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine()!);

                Console.Write("Your choice[s - student], [w - worker]: ");
                string choice = Console.ReadLine()!;

                switch(choice)
                {
                    case "s":
                        Console.Write("Grade: ");
                        double grade = double.Parse(Console.ReadLine()!);

                        Human student = new Student(firstName, lastName, age, grade);
                        humans.Add(student);
                        break;
                    case "w":
                        Console.Write("Wage: ");
                        decimal wage = decimal.Parse(Console.ReadLine()!);

                        Console.Write("Hours worked: ");
                        int hoursWorked = int.Parse(Console.ReadLine()!);

                        Human worker = new Worker(firstName, lastName, age, wage, hoursWorked);    
                        humans.Add(worker);
                        break;
                }
            }

            Console.WriteLine();

            for (int i = humans.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(humans[i]);
            }
        }
    }
}

/* 26. Създайте конзолен проект с име zad_26. Напишете class Human, който да има
следните характеристики:
• firstName (име): знаков низ;
• lastName(фамилия): знаков низ;
• age (възраст): цяло число.
Обектите на класа да са immutable (характеристиките им не могат да се променят
след конструирането на обекта). Класът да има конструктор, който задава
стойности на характеристиките.
Пренапишете метода ToString (C#)/ toString(Java) - override, така че да връща низа:
Име Фамилия, възраст years old
Дефинирайте клас Student, наследяващ Human и съдържащ допълнителна
характеристика:
• grade (оценка) : реално число.
Обектите на класа Student да са immutable (характеристиките им не могат да се
променят след конструирането на обекта). Класът да има конструктор, който
задава стойности на характеристиките. Пренапишете метода ToString (C#)/
toString(Java) - override, така че да връща:
Име Фамилия, възраст years old, grade: оценка
Оценката да бъде форматирана до втората цифра след десетичния разделител.
Дефинирайте клас Worker, наследяващ Human и дефиниращ следните
допълнителни характеристики:
•wage (надница за 1 отработен час) : реално число;
•workHours (изработени часове) :цяло число.
Обектите на класа Worker да са immutable (характеристиките им не могат да се
променят след конструирането на обекта). Класът да има конструктор, който
задава стойности на характеристиките.
Метод Salary(C#)/salary(Java), който пресмята и връща заплатата на работника:
(заплата = надницата * изработените часове).
Пренапишете метода ToString (C#)/ toString(Java) - override, така че да връща:
Име Фамилия, години years old, salary: $заплата.
Заплатата да бъде форматирана до втората цифра след десетичния разделител.
Напишете програма, която прочита от първия ред на стандартния вход цяло число
n - броя на хората. Следващите редове ще съдържат информация за n студенти
и/или работници. За всеки от тях първите три реда ще съдържат съответно името,
фамилията и възрастта.
След това програмата трябва да извежда меню от вида:
Your choice [s-student], [w- -worker]:
и да прочита въведения от потребителя символ (s или w).
Ако се въведе s – програмата да прочете успеха на ученика, а ако потребителя
въведе w – от следващите два реда програмата да прочита съответно надницата и
броя на отработените часове.
Прочетените данни да се съхраняват в обекти от съответния тип. Програмата
трябва да извежда на стандартния изход списък на въведените данни в ред, обратен
на въвеждането. За всеки студент или работник данните да се извеждат на нов ред.

 Пример
Вход:
n=3
First name: Jhon
Last name: Smith
Age: 56
Your choice[s - student] , [w - worker]: w
Wage: 35.45
Hours worked: 40
First name: Sara
Last name: Parker
Age: 23
Your choice[s - student] , [w - worker]: s
Grade: 5.25
First name: George
Last name: Mikel
Age: 45
Your choice[s - student] , [w - worker]: w
Wage: 92
Hours worked: 36
Изход:
George Mikel, 45 years old, salary: $3312.00
Sara Parker, 23 years old, grade: 5.25
Jhon Smith, 56 years old, salary: $1418.00
 
 
 */
