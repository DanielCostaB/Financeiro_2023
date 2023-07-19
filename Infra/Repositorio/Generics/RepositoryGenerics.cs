using Domain.interfaces.Generics;
using Infra.Configuracao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio.Generics
{
    public class RepositoryGenerics<T> : InterfaceGeneric<T> where T : class
    {
        private readonly DbContextOptions<ContextoBase> _OptionsBuilder;

        public RepositoryGenerics() 
        {
            _OptionsBuilder = new DbContextOptions<ContextoBase>();
        }

        public async Task Add(T obj)
        {
            using (var data = new ContextoBase(_OptionsBuilder))
            {
                await data.Set<T>().AddAsync(obj);
                await data.SaveChangesAsync();
            }
        }

        public async Task Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> List()
        {
            throw new NotImplementedException();
        }

        public async Task Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
