//Базові завдання

// Завдання 1
Console.WriteLine("Завдання 1");
Console.WriteLine("Serdiuk Danil");
double A, G, H;
A = 10;
G = 12.5 * A;
H = 8.5 * G + (9 + 3 * A) / (A + 1);
Console.WriteLine($"a={A}, x={G}; y={H}");
double Y = Math.Sqrt(H);
double X = Math.Pow(G, A);
Console.WriteLine($"korin iz y={Y},");
Console.WriteLine($"x^a={X}");




Console.WriteLine();
Console.WriteLine();



// Завдання 2
Console.WriteLine("Завдання 2");
Console.WriteLine("Serdiuk Danil");  
Console.Write("Введіть кількість хвилин: "); 
int totalMinutes = int.Parse(Console.ReadLine()); 
int hours = totalMinutes / 60; 
int minutes = totalMinutes % 60;
Console.WriteLine($"Результат: {hours}:{minutes}");




Console.WriteLine();
Console.WriteLine();


// Завдання 3
Console.WriteLine("Serdiuk Danil");  
Console.Write("Введіть ціну булочки (грн): ");
int гривні = int.Parse(Console.ReadLine()); 
Console.Write("Введіть ціну булочки (коп): ");
int копійки = int.Parse(Console.ReadLine()); 
Console.Write("Введіть кількість булочок: ");
int кількість = int.Parse(Console.ReadLine());  
int totalкопійки = (гривні * 100 + копійки) * кількість;
int totalгривні = totalкопійки / 100; 
int remainingкопійки = totalкопійки % 100;  
Console.WriteLine($"За {кількість} булочок необхідно заплатити {totalгривні} гривень {remainingкопійки} копійок.");



Console.WriteLine();
Console.WriteLine();



// Завдання 4
Console.WriteLine("Serdiuk Danil");
Console.Write("Введіть кількість комп'ютерів у класі 1: ");
int C1 = int.Parse(Console.ReadLine()); 
Console.Write("Введіть кількість комп'ютерів у класі 2: ");
int C2 = int.Parse(Console.ReadLine()); 
Console.WriteLine($"Вересень: Клас No1 - {C1}, Клас 2 - {C2}");  
int temp = C1;  
C1 = C2;
C2 = temp;
Console.WriteLine($"Жовтень: Клас N1 - {C1}, Клас 2 - {C2}"); 
C1 += 3; 
C2 -= 2;  
Console.WriteLine($"Грудень: Клас N1 - {C1}, Клас N 2 - {C2}");  
