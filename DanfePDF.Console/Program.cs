using DanfePDF.Esquemas.NFe;
using DanfePDF.Modelo;
using System;

namespace DanfePDF.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var modelo = DanfeViewModelCreator.CriarDeArquivoXml(@"C:\Users\thiag\Downloads\29201226796739000226550020000000071956807210.xml");

            using (var danfe = new Danfe(modelo))
            {
                danfe.Gerar();
                danfe.Salvar(@"C:\Users\thiag\Downloads\danfe.pdf");
            }
        }
    }
}
