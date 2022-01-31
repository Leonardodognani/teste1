class Principal{
    static void Main(){
        
        int i;
        int i2 = i = 10;
        Console.WriteLine("Testando o programa com sucesso mais o número (concatenado) de " + i + ".");
        i++;
        Console.WriteLine("Testando o programa com sucesso novamente mais o número (concatenado e com incremento) = " + i + ".");

        Console.WriteLine("Escreva algo (ou apenas aperte ENTER =)");
        Console.ReadLine();
        Console.WriteLine("Não faz diferença, o programa roda do mesmo jeito^^");
    }
}