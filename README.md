# DanfePDF

DanfePDF é uma biblioteca em C# que permite a geração do DANFE em formato PDF feito com .net Standard.

O Projeto foi refatorado e convertido para funcionar com .net Standard a partir do projeto 
[DanfeSharp](https://github.com/SilverCard/DanfeSharp) (Feito em .net Famework 4.0 e não atualizado mais)

A biblioteca PdfClown.NetStandard é utilizada para a escrita dos arquivos em PDF.

|Name|Info|
| ------------------- | :------------------: |
|DanfePDF|[![NuGet](https://buildstats.info/nuget/DanfePDF)](https://www.nuget.org/packages/DanfePDF/)|

Exemplo de uso:
```csharp

using DanfeSharp;
using DanfeSharp.Modelo;

//Cria o modelo a partir do arquivo Xml da NF-e.
var modelo = DanfeViewModelCreator.CriarDeArquivoXml("nfe.xml");


//O modelo também pode ser criado e preenchido de outra forma.
var modelo = new DanfeViewModel()
{
    NfNumero = 123456,
    NfSerie = 123,
    ChaveAcesso = "123456987...",
    Emitente = new EmpresaViewModel()
    {
        CnpjCpf = "123456...",
        Nome = "DanfeSharp Ltda",    
	...


//Inicia o Danfe com o modelo criado
using (var danfe = new Danfe(modelo))
{
	danfe.Gerar();
	danfe.Salvar("danfe.pdf");
}
```

[Exemplos Aqui](https://github.com/TBertuzzi/DanfePDF/tree/main/DanfePDF.Console)
