using DanfePDF.Esquemas.NFe;
using DanfePDF.Modelo;
using System;

namespace DanfePDF.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var modelo = DanfeViewModelCreator.CriarDeArquivoXml(@"seu xml");

            using (var danfe = new Danfe(modelo))
            {
                danfe.Gerar();
                danfe.Salvar(@"saida");
            }
        }
    }
}
