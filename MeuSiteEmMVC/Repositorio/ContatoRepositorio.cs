using MeuSiteEmMVC.Data;
using MeuSiteEmMVC.Models;
using System.Linq;
using System.Collections.Generic;
using MeuSiteEmMVC.Repositório;

namespace MeuSiteEmMVC.Repositorio {
    public class ContatoRepositorio : IContatoRepositorio {

        private readonly AppDBContext _bancoContext;
        public ContatoRepositorio(AppDBContext bancoContext) {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato) {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public List<ContatoModel> BuscarTodos() {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel ListarPorId(int id) {
            return (ContatoModel)_bancoContext.Contatos.Where(c => c.Id == id);
        }
    }
}
