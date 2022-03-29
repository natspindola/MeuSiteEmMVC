﻿using MeuSiteEmMVC.Data;
using MeuSiteEmMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuSiteEmMVC.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
    }
}