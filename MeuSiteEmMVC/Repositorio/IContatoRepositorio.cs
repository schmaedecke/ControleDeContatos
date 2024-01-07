using MeuSiteEmMVC.Models;
using System.Collections.Generic;

namespace MeuSiteEmMVC.Repositório {
    public interface IContatoRepositorio {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
