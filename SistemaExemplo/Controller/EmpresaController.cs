using SistemaExemplo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaExemplo.Controller
{
    
    public static class EmpresaController
    {
        public static Context context;
       
        static EmpresaController()
        {
            context = new Context();
        }

        public static void Inserir(Empresa Empresa)
        {
            context.Empresa.Add(Empresa);
            context.Entry(Empresa).State = Empresa.ID > 0 ? Microsoft.EntityFrameworkCore.EntityState.Modified :
                Microsoft.EntityFrameworkCore.EntityState.Added;
            context.SaveChanges();
        }
        public static Empresa GetEmpresa(int ID )
        {
            return context.Empresa.Where(c => c.ID == ID).FirstOrDefault();
        }
        public static List<Empresa> GetEmpresas()
        {
            return context.Empresa.ToList();
        }
        public static List<Empresa> GetEmpresasAtivo(string CNPJ)
        {
            return context.Empresa.Where(c=>c.CNPJ == CNPJ).ToList();
        }

        public static void Delete(int ID)
        {
            Empresa Empresa = GetEmpresa(ID);
            context.RemoveRange(Empresa);
            context.SaveChanges();
        }


    }
}
