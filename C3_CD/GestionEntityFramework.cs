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
    public class GestionEntityFramework
    {
        ContextCrud context;
        public GestionEntityFramework()
        {
            InitializeConection();
            CreateDatabase();
        }

        public void InitializeConection()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContextCrud>();
            optionsBuilder.UseSqlServer("Server=ACER-NITRO-5;Database=Estudio;Integrated Security=true;Encrypt=True;TrustServerCertificate=True;");
            context = new ContextCrud(optionsBuilder.Options);
        }

        public void CreateDatabase()
        {
            context.Database.EnsureCreated();
        }

        public List<object> BuscarPorColumna(Type tipoEntidad, string nombreColumna, object valorBuscado)
        {
            MethodInfo dbSetMethod = typeof(DbContext).GetMethod("Set", new Type[] { });
            MethodInfo dbSetGenericMethod = dbSetMethod.MakeGenericMethod(tipoEntidad);
            object dbSet = dbSetGenericMethod.Invoke(this, null);

            ParameterExpression parameter = Expression.Parameter(tipoEntidad, "e");
            MemberExpression property = Expression.Property(parameter, nombreColumna);
            ConstantExpression constant = Expression.Constant(valorBuscado);
            BinaryExpression equals = Expression.Equal(property, constant);
            LambdaExpression lambda = Expression.Lambda(equals, parameter);

            //var lambda = Expression.Lambda(Expression.Equal(Expression.Property(Expression.Parameter(tipoEntidad, "e"), nombreColumna),Expression.Constant(valorBuscado)),Expression.Parameter(tipoEntidad, "e"));

            object queryable = (IQueryable)dbSet;

            MethodInfo whereMethod = typeof(Queryable).GetMethods()
                .First(m => m.Name == "Where" && m.GetParameters().Length == 2)
                .MakeGenericMethod(tipoEntidad);

            object filtered = whereMethod.Invoke(null, new object[] { queryable, lambda });

            MethodInfo toListMethod = typeof(Enumerable)
                .GetMethods()
                .First(m => m.Name == "ToList" && m.GetParameters().Length == 1)
                .MakeGenericMethod(tipoEntidad);
            IEnumerable filteredEnumerable = filtered as IEnumerable;

            object results = toListMethod.Invoke(null, new object[] { filteredEnumerable });
            List<object> objectList = new List<object>();
            foreach (var item in (IEnumerable)results)
            {
                objectList.Add(item);
            }
            return objectList;
        }

        public List<object> ListarTodos(Type tipoEntidad)
        {

            MethodInfo dbSetMethod = typeof(DbContext).GetMethod("Set", Type.EmptyTypes);
            MethodInfo dbSetGenericMethod = dbSetMethod.MakeGenericMethod(tipoEntidad);
            object dbSet = dbSetGenericMethod.Invoke(this, null);
            MethodInfo toListMethod = typeof(Enumerable)
                .GetMethods()
                .First(m => m.Name == "ToList" && m.GetParameters().Length == 1)
                .MakeGenericMethod(tipoEntidad);
            IEnumerable dbSetEnumerable = dbSet as IEnumerable;
            object results = toListMethod.Invoke(null, new object[] { dbSetEnumerable });
            List<object> objectList = new List<object>();
            foreach (var item in (IEnumerable)results)
            {
                objectList.Add(item);
            }
            return objectList;
        }

        public void ActualizarEntidad(Type tipoEntidad, object entidadActualizar)
        {
            object[] arrayId = new object[1];
            MethodInfo dbSetMethod = typeof(DbContext).GetMethod("Set", Type.EmptyTypes);
            MethodInfo dbSetGenericMethod = dbSetMethod.MakeGenericMethod(tipoEntidad);
            object dbSet = dbSetGenericMethod.Invoke(this, null);
            PropertyInfo idProp = tipoEntidad.GetProperty("Id");
            arrayId[0] = (int)idProp.GetValue(entidadActualizar);
            var entidadExistente = dbSet.GetType().GetMethod("Find").Invoke(dbSet, new object[] { arrayId });
            context.Entry(entidadExistente).CurrentValues.SetValues(entidadActualizar);
            context.SaveChanges();
        }

        public void EliminarEntidad(Type tipoEntidad, object entidadEliminar)
        {
            object[] arrayId = new object[1];
            MethodInfo dbSetMethod = typeof(DbContext).GetMethod("Set", Type.EmptyTypes);
            MethodInfo dbSetGenericMethod = dbSetMethod.MakeGenericMethod(tipoEntidad);
            object dbSet = dbSetGenericMethod.Invoke(this, null);
            PropertyInfo idProp = tipoEntidad.GetProperty("Id");
            arrayId[0] = (int)idProp.GetValue(entidadEliminar);
            var entidadExistente = dbSet.GetType().GetMethod("Find").Invoke(dbSet, new object[] { arrayId });
            context.Remove(entidadExistente);
            context.SaveChanges();
        }

        public void CargarEntidad(Type tipoEntidad, object entidadAgregar)
        {
            MethodInfo dbSetMethod = typeof(DbContext).GetMethod("Set", Type.EmptyTypes);
            MethodInfo dbSetGenericMethod = dbSetMethod.MakeGenericMethod(tipoEntidad);
            object dbSet = dbSetGenericMethod.Invoke(this, null);
            MethodInfo addMethod = dbSet.GetType().GetMethod("Add");
            addMethod.Invoke(dbSet, new object[] { entidadAgregar });
            context.SaveChanges();
        }
    }
}
