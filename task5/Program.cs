//Напишите программу, которая на вход получает число N, а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Enter integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = -number;
while(i<=number){
    Console.Write(i+" " );
    i++;
}