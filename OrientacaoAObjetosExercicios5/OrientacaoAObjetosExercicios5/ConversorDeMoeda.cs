using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetosExercicios5
{
    internal class ConversorDeMoeda
    {
        /// <summary>
        ///     Recebe a cotação do dolar e o valor desejado da compra
        /// </summary>
        /// <param name="cotacao">Double que representa a cotação do dolar</param>
        /// <param name="valorCompra">Double que representa o valor a ser comprado em Reais</param>
        /// <returns> retorna o valor a ser pago com o imposto de 6%</returns>
        public static double ValorPagarReais(double cotacao, double valorCompra)
        {
            double valorEmDolar = valorCompra * cotacao;
            return valorEmDolar + (valorEmDolar * 0.06);
        }
    }
}
