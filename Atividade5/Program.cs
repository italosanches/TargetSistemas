//5) Escreva um programa que inverta os caracteres de um string.

//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse;
//olait
ReverterString("italo");
ReverterString("Meu Texto");

static void ReverterString(string texto)
{
    char[] caracteres = texto.ToCharArray();

    for (int i = 0; i < caracteres.Length / 2; i++)
    {

        char temp = caracteres[i];
        caracteres[i] = caracteres[caracteres.Length -i -1 ];
        caracteres[caracteres.Length -1 -i ] = temp;
    }

    Console.WriteLine(new string(caracteres));
}