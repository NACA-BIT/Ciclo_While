/*Número válido garantizado
Pida un número entre 1 y 10. Si el usuario digita cualquier otra cosa, avísele y vuelva a preguntar. 
Use Repetir…Hasta Que: la pregunta se hace al menos una vez, siempre.*/
int numero;
do
{
    Console.WriteLine("Manito dime un numero del 1 al 10");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 10 || numero <= 0)
    {
        Console.WriteLine("Manito, te dije que un numero del 1 al 10, vuelvelo a intentar porfavor");
    }
}
while (numero > 10 || numero <= 0);

Console.WriteLine("Numero correcto :D");
