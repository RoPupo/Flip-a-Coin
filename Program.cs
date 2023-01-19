Random Moeda = new Random();
int flip = Moeda.Next(0, 2);
string Escolha;
string Continuar = "S";
int resultado = 0;
while (Continuar == "S")
{

    Console.WriteLine("BEM VINDO AO CARA OU COROA" +
        "");
    Console.WriteLine("Cara ou Coroa?");
    Escolha = Console.ReadLine();
    if (Escolha == "Cara")
    {
        resultado = 0;
    }
    if (Escolha == "Coroa")
    {
        resultado = 1;
    }
    if (flip == resultado)
    {

        Console.WriteLine("Parabéns você ganhou");
        Console.WriteLine("Revanche? (S)im ou (N)ao");
        Continuar = Console.ReadLine();
    }
    if (flip != resultado)
    {
        Console.WriteLine("Poxa, você perdeu... Quer tentar denovo? (S)im ou (N)ao ?");


        Continuar = Console.ReadLine();
    }
}