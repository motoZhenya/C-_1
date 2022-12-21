// Выяснить, кратно ли число заданному, если нет, вывести остаток

Console.Write("Введите первое число: ");
Double A = Double.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
Double S = Double.Parse(Console.ReadLine()!);


   if ( A % S == 0 )
   {
        Console.Write("Первое число кратно второму");
   }
   else
   {
    Console.WriteLine(A/S);
    Console.WriteLine("Число не кратно");
   }
