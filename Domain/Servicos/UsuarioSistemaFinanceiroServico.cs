using Domain.interfaces.InterfaceServicos;
using Domain.interfaces.IUsuarioSistemaFinanceiro;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class UsuarioSistemaFinanceiroServico : IUsuarioSistemaFinanceiroServico
    {
     
            private readonly InterfaceUsuarioSistemaFinanceiro _interfaceUsuarioSistemaFinanceiro;

            public UsuarioSistemaFinanceiroServico(InterfaceUsuarioSistemaFinanceiro interfaceUsuarioSistemaFinanceiro)
            {
                _interfaceUsuarioSistemaFinanceiro = interfaceUsuarioSistemaFinanceiro;
            }
           
            public async Task CadastrarUsuarioNoSistema(UsuarioSistemaFinanceiro usuarioSistemaFinanceiro)
            {
                await _interfaceUsuarioSistemaFinanceiro.Add(usuarioSistemaFinanceiro);
            }
        }

    }
}
