/*Descenso de 3 en 3
Lea un número de inicio y vaya imprimiendo la cuenta restando de 3 en 3 
mientras el valor siga siendo positivo. Al terminar: "Fin del descenso".*/
int numero;
Console.WriteLine("Dime un numero, el que sea");
numero=Convert.ToInt32(Console.ReadLine());

while (numero>1)
{
        numero = numero - 3;
        Console.WriteLine(numero);  
    
}
Console.WriteLine("Fin del descenso");