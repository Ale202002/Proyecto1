using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Generic
{
    public interface IGenericRepository<T> where T : class, new()
    {
        Task<IEnumerable<T>> GetAsync();

        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> whereCondition = null);

        Task<T> GetByIdAsync(int id);

        Task<bool> CreateAsync(object entity);

        Task<bool> UpdateByIdAsync(int id, object entity);

        Task<bool> DeleteByIdAsync(int id);

    }
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenericRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _unitOfWork.Context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> whereCondition = null)
        {
            IQueryable<T> query =_unitOfWork.Context.Set<T>();
            if(whereCondition != null)
            {
                query = query.Where(whereCondition);
            }
            return await query.ToListAsync();
        }

        public async Task<bool> CreateAsync(object entity)
        {
            try
            {
                T finalEntity = new T();
                PropertyInfo[] properties = entity.GetType().GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    PropertyInfo finalEntityProperty = finalEntity.GetType().GetProperty(property.Name);
                    if (finalEntityProperty != null && finalEntityProperty.CanWrite)
                    {
                        finalEntityProperty.SetValue(finalEntity, property.GetValue(entity));
                    }
                }
                await _unitOfWork.Context.Set<T>().AddAsync(finalEntity);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _unitOfWork.Context.Set<T>().FindAsync(id);
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            try
            {
                T entity = await GetByIdAsync(id);
                if (entity != null)
                {
                    _unitOfWork.Context.Set<T>().Remove(entity);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateByIdAsync(int id, object entity)
        {
            try
            {
                T existingEntity = await GetByIdAsync(id);
                if (existingEntity != null)
                {
                    PropertyInfo[] properties = entity.GetType().GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        PropertyInfo finalEntityProperty = existingEntity.GetType().GetProperty(property.Name);
                        if (finalEntityProperty != null && finalEntityProperty.CanWrite)
                        {
                            finalEntityProperty.SetValue(existingEntity, property.GetValue(entity));
                        }
                    }
                    _unitOfWork.Context.Set<T>().Update(existingEntity);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
