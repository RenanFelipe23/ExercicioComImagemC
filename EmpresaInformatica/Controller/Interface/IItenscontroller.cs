using EmpresaInformatica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaInformatica.Controller.Interface
{
    public interface IItenscontroller
    {
        void InserirRegistro(string descricao);
        List<Itens> RetornaLista();
    }
}
