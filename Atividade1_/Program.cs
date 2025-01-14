////1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
////Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
////Imprimir(SOMA);
////Ao final do processamento, qual será o valor da variável SOMA?

Somar(13);
static void Somar(int indice)
{
    int soma = 0;
    for (int k = 0; k < indice; k++)
    {
        soma = soma + k;
    }
    Console.WriteLine(soma);
}

