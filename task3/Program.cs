// Напишите программу , которая будет выдавать название дня недели по заданному номеру

Console.Write("Entrer number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 1){
Console.WriteLine("This is Monday");
}
else if(number == 2){
Console.WriteLine("This is Tuesday");
}
else if(number == 3){
Console.WriteLine("This is Wendesday");
}

else if(number == 4){
Console.WriteLine("This is Thursday");
}

else if(number == 5){
Console.WriteLine("This is Friday");
}

else if(number == 6){
Console.WriteLine("This is Sunday");
}

else if(number == 7){
Console.WriteLine("This is Saturday");
}

else if(number < 1 || number > 7 ){
Console.WriteLine("There is no such day of the week");
}




