using SistemaExemplo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaExemplo.Controller
{
    
    public static class ClienteController
    {
        public static Context context;
       
        static ClienteController()
        {
            context = new Context();
        }

        public static void Inserir(Cliente cliente)
        {
            context.Cliente.Add(cliente);
            context.Entry(cliente).State = cliente.ID > 0 ? Microsoft.EntityFrameworkCore.EntityState.Modified :
                Microsoft.EntityFrameworkCore.EntityState.Added;
            context.SaveChanges();
        }
        public static Cliente GetCliente(int ID )
        {
            return context.Cliente.Where(c => c.ID == ID).FirstOrDefault();
        }
        public static List<Cliente> GetClientes()
        {
            return context.Cliente.ToList();
        }
        public static List<Cliente> GetClientesAtivo(bool Ativo)
        {
            return context.Cliente.Where(c=>c.Ativo == Ativo).ToList();
        }

        public static void Delete(int ID)
        {
            Cliente cliente = GetCliente(ID);
            context.RemoveRange(cliente);
            context.SaveChanges();
        }


    }
}
