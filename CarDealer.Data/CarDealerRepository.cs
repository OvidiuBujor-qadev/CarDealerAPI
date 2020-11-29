using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealer.Data
{
    public class CarDealerRepository: IRepositoryCarDealer
    {
        private CarDealerDbContext _dbcontext;
        public CarDealerRepository(CarDealerDbContext dbContext) 
        {
            _dbcontext = dbContext;
        }
        public T Create<T>(T entity) where T: ModelBase
        {
            entity.IsDeleted = false;
            return _dbcontext.Add<T>(entity).Entity;
        }

        public void Delete<T>(int Id) where T: ModelBase
        {
            var entity = _dbcontext.Set<T>().FirstOrDefault(e=>e.Id == Id );
            entity.IsDeleted = true;
            _dbcontext.SaveChanges();
        }

        public List<T> Get<T>() where T : ModelBase 
        {
            var entity = _dbcontext.Set<T>().Where(e=>!e.IsDeleted).ToList();
            return entity;
        }

        public T GetById<T>(int id) where T: ModelBase
        {
            var entity = _dbcontext.Set<T>().FirstOrDefault(e=>e.Id == id);
            return entity;
        }

        public T Update<T>(T _entity) where T: ModelBase
        {
            var entity = _dbcontext.Set<T>().Update(_entity);
            return entity.Entity;
        }

        public void SaveChanges() 
        {
            _dbcontext.SaveChanges();
        }
    }
}
