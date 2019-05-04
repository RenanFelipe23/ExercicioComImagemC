using EmpresaInformatica.Controller.Interface;
using EmpresaInformatica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaInformatica.Controller
{
    public class Itencontroller : IItenscontroller
    {
        private IUnitOfWork unitOfWork;
        public Itencontroller()
        {
            unitOfWork = new UnitOfWork();
        }
        public void InserirRegistro(string descricao)
        {
            unitOfWork.Inserir(descricao);
        }

        public List<Itens> RetornaLista()
        {
            return unitOfWork.RetornaLista();
        }
    }
}
