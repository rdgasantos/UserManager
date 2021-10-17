using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Domain.Entities;
using UserManager.Domain.Interfaces;
using UserManager.Infrasctructure.Data.Context;

namespace UserManager.Infrasctructure.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly UserManagerContext _userManagerContext;
        public BaseRepository(UserManagerContext userManagerContext)
        {
            _userManagerContext = userManagerContext;
        }
        public void Delete(int id)
        {
            _userManagerContext.Set<TEntity>().Remove(Select(id));
            _userManagerContext.SaveChanges();
        }

        public void Insert(TEntity obj)
        {
            _userManagerContext.Set<TEntity>().Add(obj);
            _userManagerContext.SaveChanges();
        }

        public IList<TEntity> Select() =>
             _userManagerContext.Set<TEntity>().ToList();

        public TEntity Select(int id) =>
            _userManagerContext.Set<TEntity>().Find(id);

        public void Update(TEntity obj)
        {
            _userManagerContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _userManagerContext.SaveChanges();
        }
    }
}
