/*Doble validación (el jefe final)
Para calcular el área de un rectángulo se necesitan base y altura positivas. 
Pida ambos datos dentro de un Repetir; si cualquiera de los dos falla, 
avise y vuelva a pedir el par completo. Cuando ambos sean válidos, calcule y muestre el área.*/

double Base, altura, area;

do
{
    Console.WriteLine("Manito, dime la base de tu rectangulo");
    Base=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ahora dime la altura de tu rectangulo");
    altura=Convert.ToDouble(Console.ReadLine());
    if (Base <= 0 || altura <= 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\n\nAlguno de los campos no es valido\nPorfavor Intentelo Nuevamente\n\n");
        Console.Beep(500, 200);
        Console.ResetColor();
    }

}
while (Base<=0||altura<=0);
area = Base * altura;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"El area del rectangulo es {area} :D");
Console.Beep(1000, 300);
Console.ResetColor();
