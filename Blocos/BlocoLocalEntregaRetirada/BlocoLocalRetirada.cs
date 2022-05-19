﻿using DanfePDF.Modelo;

namespace DanfePDF.Blocos
{
    class BlocoLocalRetirada : BlocoLocalEntregaRetirada
    {
        public BlocoLocalRetirada(DanfeViewModel viewModel, Estilo estilo) 
            : base(viewModel, estilo, viewModel.LocalRetirada)
        {
        }

        public override string Cabecalho => "Informações do local de retirada";
    }
}
