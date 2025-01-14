//4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
//• SP – R$67.836,43
//• RJ – R$36.678,66
//• MG – R$29.229,88
//• ES – R$27.165,48
//• Outros – R$19.849,53
//Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.  
FaturamentoEstado.CalcularPercentualFaturamento();

public class FaturamentoEstado
{
    public string Estado { get; set; }
    public decimal Valor { get; set; }
    public static void CalcularPercentualFaturamento()
    {
        List<FaturamentoEstado> faturamentoEstados = new List<FaturamentoEstado>
        {
        new FaturamentoEstado { Estado = "SP", Valor = 67836.43m },
        new FaturamentoEstado { Estado = "RJ", Valor = 36678.66m },
        new FaturamentoEstado { Estado = "MG", Valor = 29229.88m },
        new FaturamentoEstado { Estado = "ES", Valor = 27165.48m },
        new FaturamentoEstado { Estado = "Outros", Valor = 19849.53m }
        };
        decimal totalFaturamento = faturamentoEstados.Sum(faturamento => faturamento.Valor);
        foreach (var faturamentoEstado in faturamentoEstados)
        {
            decimal percentual = (faturamentoEstado.Valor / totalFaturamento) * 100;
            Console.WriteLine($"O estado {faturamentoEstado.Estado} teve um percentual de {percentual.ToString("N2")}% no faturamento total");
        }
    }
}

