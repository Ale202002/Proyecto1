using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C3_CD
{
    public class GestionEntityFramework<T> where T : class
    {
        private readonly ContextCrud context;

        public GestionEntityFramework()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContextCrud>();
            optionsBuilder.UseSqlServer("Server=ACER-NITRO-5;Database=Estudio;Integrated Security=true;Encrypt=True;TrustServerCertificate=True;");
            context = new ContextCrud(optionsBuilder.Options);
        }

        public async Task<List<T>> GetAsync()
        {
            Dispose();
            return await context.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetAsync(Expression<Func<T, bool>> whereCondition = null)
        {
            IQueryable<T> query = context.Set<T>();
            if (whereCondition != null)
            {
                query = query.Where(whereCondition);
            }
            Dispose();
            return await query.ToListAsync();
        }

        public async Task<bool> CreateAsync(T entity)
        {
            try
            {
                PropertyInfo propertyId = entity.GetType().GetProperty("Id");
                PropertyInfo propertyDate = entity.GetType().GetProperty("FechaRegistro");
                if (propertyId != null && propertyDate == null)
                {
                    await context.Set<T>().AddAsync(entity);
                    Commit();
                    return true;
                }
                else if (propertyDate != null && propertyDate.CanWrite)
                {
                    propertyDate.SetValue(entity, DateTime.Now);
                    await context.Set<T>().AddAsync(entity);
                    Commit();
                    return true;
                }
                else
                {
                    Dispose();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            try
            {
                T entity = await GetByIdAsync(id);
                if (entity != null)
                {
                    context.Set<T>().Remove(entity);
                    Commit();
                    return true;
                }
                else
                {
                    Dispose();
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateByIdAsync(int id, T entity)
        {
            try
            {
                T existingEntity = await GetByIdAsync(id);
                if (existingEntity != null)
                {
                    PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    foreach (var property in properties)
                    {
                        var newValue = property.GetValue(entity);
                        if (newValue != null && property.Name != "Id" && property.Name != "FechaRegistro")
                        {
                            property.SetValue(existingEntity, newValue);
                        }
                    }
                    context.Set<T>().Update(existingEntity);
                    Commit();
                    return true;
                }
                else
                {
                    Dispose();
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
