using Newtonsoft.Json;

////3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
////• O menor valor de faturamento ocorrido em um dia do mês;
////• O maior valor de faturamento ocorrido em um dia do mês;
////• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

Faturamento.CalcularFaturamento();

public class Faturamento
{
    public int Dia { get; set; }
    public decimal Valor { get; set; }
    public static void CalcularFaturamento()
    {
        List<Faturamento> dadosFaturamento = ObterDadosFaturamentoJson();
        MenorValorFaturamento(dadosFaturamento);
        MaiorFaturamento(dadosFaturamento);
        DiasSuperiorMediaMensal(dadosFaturamento);
    }

    public static List<Faturamento> ObterDadosFaturamentoJson()
    {
        string diretorioAtual = Directory.GetCurrentDirectory();
        string diretorioProjetoAtual = Path.Combine(diretorioAtual, "../../../");
        string arquivoDadosJson = Path.Combine(diretorioProjetoAtual, "dados.json");

        if (File.Exists(arquivoDadosJson))
        {
            string json = File.ReadAllText(arquivoDadosJson);
            List<Faturamento> faturamento = JsonConvert.DeserializeObject<List<Faturamento>>(json);
            return faturamento;
        }
        else
        {
            Console.Write("Arquivo não encontrado!");
            return null;
        }
    }
    public static void MenorValorFaturamento(List<Faturamento> ListaFaturamento)
    {
        Faturamento? menorValorFaturamento = ListaFaturamento.Where(faturamento => faturamento.Valor > 0.0m)
                                                        .MinBy(faturamento => faturamento.Valor);
        Console.WriteLine($"O menor faturamento foi no dia {menorValorFaturamento.Dia} e o valor foi {menorValorFaturamento.Valor.ToString("C")}");
    }
    public static void MaiorFaturamento(List<Faturamento> ListaFaturamento)
    {
        Faturamento? maiorValorFaturamento = ListaFaturamento.Where(faturamento => faturamento.Valor > 0.0m)
                                                             .MaxBy(faturamento => faturamento.Valor);
        Console.WriteLine($"O maior faturamento foi no dia {maiorValorFaturamento.Dia} e o valor foi {maiorValorFaturamento.Valor.ToString("C")}");
    }

    public static void DiasSuperiorMediaMensal(List<Faturamento> ListaFaturamento)
    {
        decimal mediaMensal = ListaFaturamento.Where(faturamento => faturamento.Valor > 0.0m)
                                              .Average(faturamento => faturamento.Valor);
        int diasSuperiorMedia = ListaFaturamento.Where(faturamento => faturamento.Valor > mediaMensal)
                                              .Count();
        Console.WriteLine($"O número de dias no mês em que o valor de faturamento diário foi superior à média mensal foi {diasSuperiorMedia} dias");
    }


}