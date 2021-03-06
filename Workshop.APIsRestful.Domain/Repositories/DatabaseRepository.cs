using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.APIsRestful.Domain.Models;

namespace Workshop.APIsRestful.Domain.Repositories
{
    public class DatabaseRepository<T> where T: BaseClass
    {
        private static List<T> _items = new List<T>();

        public async Task<List<T>> GetAsync()
        {
            return _items.ToList();
        }

        public async Task<T> GetAsync(Guid id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public async Task<T> Create(T model)
        {
            _items.Add(model);
            return model;
        }
        public async Task<T> Update(T updatedModel)
        {
            await Delete(updatedModel.Id);
            await Create(updatedModel);

            return updatedModel;
        }

        public async Task Delete(Guid id)
        {
            var model = await GetAsync(id);
            if (model == null)
                throw new KeyNotFoundException();

            _items.Remove(model);
        }
    }
}
