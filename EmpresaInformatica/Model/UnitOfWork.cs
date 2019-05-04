using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaInformatica.Model
{
    public class UnitOfWork: IUnitOfWork
    {
        EmpresaInformaticaContext empresa = new EmpresaInformaticaContext();
        Itens i = new Itens();

        public void Atualiza(int id, string Descricao)
        {
            i = empresa.Itens.Find(id);
            i.Descricao = Descricao;
            empresa.SaveChanges();
        }

        public void Delete(int id)
        {
            i = empresa.Itens.Find(id);
            empresa.Itens.Remove(i);
            empresa.SaveChanges();
        }

        public void Inserir(string Descricao)
        {
            i.Descricao = Descricao;
            empresa.Itens.Add(i);
            empresa.SaveChanges();
        }

        public List<Itens> RetornaLista()
        {
            return empresa.Itens.ToList();
        }
    }
}
