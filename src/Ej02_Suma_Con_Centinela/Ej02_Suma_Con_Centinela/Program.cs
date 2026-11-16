/*Suma con centinela (hasta el 0)
Lea números uno tras otro y acumúlelos. El usuario indicará el final digitando 0 (el "centinela").
Muestre la suma total. Aquí las vueltas no se saben de antemano: esa es la esencia del while.*/
int numero, sumaNumeros=0, contador=0;
Console.WriteLine("Manito, los numeros que quieras (Menos el 0 por ahora)");
numero = Convert.ToInt32(Console.ReadLine());

while (numero!=0)
{
    sumaNumeros = sumaNumeros + numero;
    contador++;
    numero = Convert.ToInt32(Console.ReadLine());
    if (contador==1)
    {
        Console.WriteLine("En caso de que no quiera digitar mas numeros escribe el numero cero y dale enter :D");
    }
}
Console.WriteLine($"La suma de tus numeros es = {sumaNumeros}");