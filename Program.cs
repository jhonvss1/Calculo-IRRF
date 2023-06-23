Console.WriteLine("---------------------VAMOS CALCULAR SEU IRRF----------------");

Console.WriteLine("Informe o nome da sua empresa: ");
string empresa = Console.ReadLine();
// Validando o nome da Empresa
    if (string.IsNullOrEmpty(empresa))
{
    Console.WriteLine("Nome da Empresa inválido");
     return;
}
if (empresa.Length <= 3)
{
    Console.WriteLine("Nome da empresa muito curto");
     return;
}
Console.WriteLine("Agora nos informe o seu nome: ");
string Name  = Console.ReadLine();
    if (string.IsNullOrEmpty(Name))
{
     Console.WriteLine("Nome do Usuário inválido");
     return;
}   
    if (Name.Length <=2)
{
        Console.WriteLine("Nome curto se for o caso digite também seu sobrenome");
     return;
}
Console.WriteLine("Seu salário Atual: ");
double Salario = Convert.ToDouble(Console.ReadLine());

if (Salario <= 1903.98)
{
    Console.WriteLine("De acordo com a tabela do IRRF dada pelo governo seu salário não é descontado");
    return;
}
else if (Salario > 1903.99 && Salario <= 2826.65)
{
    // Descobrir o desconto de acordo com o salário
    double desconto = Salario * (7.50 / 100);
    double descontado = Salario - desconto;
    Console.WriteLine($" O valor do desconto foi de R${desconto} e o seu salário descontado ficou R${descontado}");
    return;
}
else if (Salario >= 2826.66 && Salario <= 3751.05)
{
    double desconto = Salario * (15 / 100);
    double descontado = Salario - desconto;
    Console.WriteLine($"O desconto foi R${desconto} e o seu salário descontado ficou de {descontado}.");
}
else if (Salario >= 3751.06 && Salario <= 4664.68)
{
    double desconto = Salario * (22.50 / 100);
    double descontado = Salario - desconto;
    Console.WriteLine($"O desconto foi R${desconto} e o salario descontado ficou de R${descontado}");
}
else if (Salario > 4664.68)
{
    double desconto = Salario * (27.50 / 100);
    double descontado = Salario - desconto;
    Console.WriteLine($"O desconto foi de R${desconto} e o salario descontado foi de R${descontado}");
}