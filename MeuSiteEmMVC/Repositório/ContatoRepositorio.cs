using MeuSiteEmMVC.Data;
using MeuSiteEmMVC.Models;

namespace MeuSiteEmMVC.Repositório {
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
    }
}
