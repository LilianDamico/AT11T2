int c;
double num, soma, max;
Console.Write("Quantos numeros pretende digitar: ");
max = Convert.ToDouble(Console.ReadLine());
soma = 0;
Console.WriteLine("Digite " + max + " números: ");
for (c = 1; c<= max; c++)
{
    Console.Write("digite o " + c + "º numero: ");
    num = Convert.ToDouble(Console.ReadLine());
    if (num > 10)
    {
        soma = soma + num;
    }
    
    
}
Console.WriteLine(soma);



Console.ReadKey();


   
