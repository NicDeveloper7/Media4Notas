    double nota1, nota2, nota3, nota4, media;
    string resultado;
    //oq acontece se os dois or forem falso
    Console.WriteLine("----------Média----------");
    Console.WriteLine("Digite 4 notas de 0 a 10");

    Console.WriteLine("Primeira nota: ");
    nota1 = Convert.ToDouble(Console.ReadLine()!);

    Console.WriteLine("Segunda nota: ");
    nota2 = Convert.ToDouble(Console.ReadLine()!);

    Console.WriteLine("Terceira nota: ");
    nota3 = Convert.ToDouble(Console.ReadLine()!);

    Console.WriteLine("Quarta nota: ");
    nota4 = Convert.ToDouble(Console.ReadLine()!);

    bool allMentionValid = nota1 >= 0 && nota1 <= 10
                           && nota2 >= 0 && nota2 <= 10
                           && nota3 >= 0 && nota3 <= 10
                           && nota4 >= 0 && nota4 <= 10;

    //Condicional para gerar as operações caso todas as notas sejam validas
    if (allMentionValid) 
    {
        media = (nota1 + nota2 + nota3 + nota4) / 4;

        if (media < 5) 
        {
            resultado = "Reprovado";
        }
        else 
        {
            if(media > 6) 
            {
                resultado = "Aprovado";
            }
            else 
            {
                resultado = "Em recuperação";
            }
        }

        //Laço para gerar cor
        if (resultado == "Aprovado") 
        {
            Console.ForegroundColor = ConsoleColor.Green;

          
        }
        else 
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        if (resultado == "Reprovado")
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
        }


    Console.WriteLine($"Você ficou com média {media:N1}. e está {resultado:N1}");

    }
    else 
    {
        Console.WriteLine("Digite somente notas de 0 a 10 ");
    }