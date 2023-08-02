using Domain.interfaces.ICategoria;
using Domain.interfaces.IDespesa;
using Domain.interfaces.InterfaceServicos;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class DespesaServico : IDespesaServico
    {
        private readonly InterfaceDespesa _InterfaceDespesa;
        public DespesaServico(InterfaceDespesa InterfaceDespesa)
        {
            _InterfaceDespesa = _InterfaceDespesa;
        }

        public async Task AdicionarDespesa(Despesa despesa)
        {
           
        }

        public async Task AtualizarDespesa(Despesa despesa)
        {
           
        }
    }
}
