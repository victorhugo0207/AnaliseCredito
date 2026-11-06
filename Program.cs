Console.WriteLine("Olá, somos da agência de empréstimos, nos diga o valor que você gostaria de realizar o empréstimo e nós decidimos se aprovamos ou não!");

Console.Write("digite o valor do empréstimo : ");
double valorinicial = Convert.ToDouble(Console.ReadLine());

Console.Write("digite o valor desejado das parcelas : ");
double valordasparcelas = Convert.ToDouble(Console.ReadLine());

Console.Write("digite sua renda mensal : ");
double renda =  Convert.ToDouble(Console.ReadLine());

double resultado = renda * 0.3;

if (valordasparcelas <= resultado  )
 {
    Console.WriteLine("Empréstimo aprovado");
 }
else
{
    Console.WriteLine("Empréstimo negado");
}