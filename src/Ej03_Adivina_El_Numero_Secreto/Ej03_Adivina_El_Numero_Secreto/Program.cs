/*Adivina el número secreto
El programa "piensa" el número 37. El usuario intenta adivinarlo: tras cada fallo reciba "Más alto…" o "Más bajo…". 
El ciclo termina cuando acierte, y al final muestre cuántos intentos necesitó.*/
int numeroUsuario;
Console.WriteLine("Juguemos un juego, adivina en que numero estoy pensando y te ganas un premio :D");
numeroUsuario=Convert.ToInt32(Console.ReadLine());
while (numeroUsuario!=37)
{
    if (numeroUsuario>37)
    {
        Console.WriteLine("Mas bajo...");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());

    }
    else
    {
        Console.WriteLine("Mas alto...");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());

    }
}
Console.WriteLine("LE ATINASTEEEEEEEEEEE, TE GANASTE UN ABRAZO :D");

int contador = 0;
while (contador!=20)
{
    contador++;
    Console.WriteLine(":DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD");
}
