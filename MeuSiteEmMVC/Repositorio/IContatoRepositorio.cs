using MeuSiteEmMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuSiteEmMVC.Repositorio
{
    interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
