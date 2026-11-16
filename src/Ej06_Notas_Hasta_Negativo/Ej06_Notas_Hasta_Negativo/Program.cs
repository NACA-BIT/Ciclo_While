/*while(true) · Notas hasta el negativo
Lea notas una tras otra dentro de un Mientras VERDADERO (while true). Cuando el usuario digite una nota negativa, salga con Break.
Al final muestre el promedio de las notas válidas… o un aviso si no digitó ninguna.*/
double notas,contador=0, sumaNotas=0,promedio;
while (true)
{
    Console.WriteLine($"Digite su nota numero {contador+1} porfavor: ");
    notas=Convert.ToInt32( Console.ReadLine() );
    if (notas>=0)
    {
        contador++;
        sumaNotas = sumaNotas + notas;
    }
    else
    {
        break;
    }
}
promedio = sumaNotas / contador;
if (promedio==0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Beep(2000, 100);
    Console.Beep(1000, 100);
    Console.WriteLine("ERROR NINGUN VALOR DIGITADO");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor= ConsoleColor.DarkGreen;
    Console.WriteLine($"El promedio de las notas es: {promedio}");
    Console.ResetColor();
}