
int transicao,estado;

Console.WriteLine("Digite a Estado inserindo 0 ou 1");
transicao = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o Transição inserindo 0 ou 1");
estado = int.Parse(Console.ReadLine());

if (estado == 1 & transicao == 0 | estado == 2 & transicao == 0)
{
    Console.WriteLine("Seu estado Atual é 3 ");
}
else if(estado == 3 & transicao == 1)
{
    Console.WriteLine("Seu estado Atual é 2 ");
}
else if(estado == 2 & transicao == 1 & transicao == 1)
{
    Console.WriteLine("Seu estado Atual é 1" );
}
else if(estado == 2 & transicao == 0)
{
    estado = 3;
}


