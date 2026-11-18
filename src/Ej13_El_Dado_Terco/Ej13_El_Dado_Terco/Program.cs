/*El dado terco: hasta que salga 6
Simule el lanzamiento de un dado (en PSeInt con Azar(1,6), en C# con Random).
Repita el lanzamiento mostrando cada tiro hasta que salga 6, y cuente cuántos tiros hicieron falta.*/
int numero=0, contador=0;
Random rnd=new Random();
do
{
    numero = rnd.Next(1, 7);
    contador++;

    Console.WriteLine($"El numero es = {numero}");
}
while (numero != 6);
Console.WriteLine($"Hicieron falta {contador} tiros");
