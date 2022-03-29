using MeuSiteEmMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuSiteEmMVC.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
