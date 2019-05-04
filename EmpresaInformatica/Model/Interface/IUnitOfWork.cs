using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaInformatica.Model
{
    public interface IUnitOfWork
    {
        void Inserir(string Descricao);
        void Delete(int id);
        void Atualiza(int id, string Descricao);
        List<Itens> RetornaLista();
    }
}
