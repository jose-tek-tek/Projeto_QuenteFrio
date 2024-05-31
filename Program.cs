Console.Clear();
Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);
int palpite;

Console.WriteLine("--- ADIVINHE O NÚMERO ---\n");
Console.ReadKey();

Console.WriteLine("Gerando um número...");
Thread.Sleep(3000);
Console.WriteLine("Número Sorteado!!!");
Thread.Sleep(1000);

    do {
            
            Console.Write("Adivinhe o número que estou pensando!......: ");
            palpite = int.Parse(Console.ReadLine()!);

            if (palpite < valorInteiro){
                Console.WriteLine("Está Frio!!");
            }

            else if (palpite > valorInteiro){
                Console.WriteLine("Está Quente!!");
            }

            else{
                Console.WriteLine("Parabéns! Você acertou o número!");
            }

        } while (palpite != valorInteiro);

    Console.WriteLine("O número era: " + valorInteiro);
    Thread.Sleep(5000);