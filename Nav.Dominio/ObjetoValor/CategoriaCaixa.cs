using System.ComponentModel;

namespace Nav.Dominio.ObjetoValor
{
    public enum CategoriaCaixa
    {
        
        [Description("entradaCaixa")]
        Entrada = 1,

        [Description("saidaCaixa")]
        Saida,

        [Description("outrosCaixa")]
        Outros
    }
}
