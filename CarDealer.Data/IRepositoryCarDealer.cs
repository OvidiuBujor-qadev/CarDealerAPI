using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Data
{
    public interface IRepositoryCarDealer
    {
        T GetById<T>(int id) where T: ModelBase;

        List<T> Get<T>() where T : ModelBase;

        T Create<T>(T entity) where T: ModelBase;

        void Delete<T>(int Id) where T: ModelBase;

        T Update<T>(T entity) where T: ModelBase;

        void SaveChanges();
    }
}
