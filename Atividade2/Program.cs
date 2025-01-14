////2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o 
////    próximo valor sempre será a soma dos 2 valores anteriores 
////    (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), 
////    escreva um programa na linguagem que desejar onde,
////    informado um número, ele calcule a sequência de Fibonacci 
////    e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

Fibonacci(13);
Fibonacci(14);
Fibonacci(4);

Fibonacci(1);

static void Fibonacci(int numero)
{
    int a = 0;
    int b = 1;
    int c = 0;
    bool pertence = false;
    while (c < numero)
    {
        c = a + b;
        a = b;
        b = c;
        if (c == numero)
        {
            pertence = true;
            break;
        }
    }
    if (pertence)
    {
        Console.WriteLine("O número " + numero + " pertence a sequência de Fibonacci.");
    }
    else
    {
        Console.WriteLine("O número " + numero + " não pertence a sequência de Fibonacci.");
    }
}