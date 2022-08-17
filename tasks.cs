// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());
// int Exponentiation(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
//        double  expon = Math.Pow(numberA, numberB);
//     return result;
// }
//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine("Ответ: " + exponentiation);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;


    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }


int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
