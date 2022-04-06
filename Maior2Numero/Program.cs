int n1, n2;

Console.Write("Digite o primeiro número: "); 
n1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Digite o segundo número: "); 
n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{   
    Console.WriteLine($"{n1} é maior ");
}

else
{   
    Console.WriteLine($"{n2} é maior");
}