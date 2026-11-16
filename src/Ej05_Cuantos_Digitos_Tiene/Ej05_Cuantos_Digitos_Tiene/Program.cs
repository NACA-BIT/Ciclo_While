/*¿Cuántos dígitos tiene?
Lea un número entero positivo y cuente sus dígitos sin convertirlo a texto:
en cada vuelta quite la última cifra con div 10 hasta que no quede nada.*/
int numero, contador = 0;
Console.WriteLine("Manito, dime un numerito");
numero = Convert.ToInt32(Console.ReadLine());
while (numero!=0)
{ 
    numero = numero / 10;
    contador++;
}
Console.WriteLine($"El numero que ingresaste tiene {contador} digitos");

