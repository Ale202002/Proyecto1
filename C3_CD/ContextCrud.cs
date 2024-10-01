using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using C4_EN;
namespace C3_CD
{
    public class ContextCrud : DbContext
    {
        public ContextCrud(DbContextOptions<ContextCrud> options) : base(options) { }

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

        public void ActualizarEntidad(Type tipoEntidad, object entidadActualizar)
        {
            object[] arrayId = new object[1];
            MethodInfo dbSetMethod = typeof(DbContext).GetMethod("Set", Type.EmptyTypes);
            MethodInfo dbSetGenericMethod = dbSetMethod.MakeGenericMethod(tipoEntidad);
            object dbSet = dbSetGenericMethod.Invoke(this, null);
            PropertyInfo idProp = tipoEntidad.GetProperty("Id");
            arrayId[0] = (int)idProp.GetValue(entidadActualizar);
            var entidadExistente = dbSet.GetType().GetMethod("Find").Invoke(dbSet, new object[] { arrayId });
            this.Entry(entidadExistente).CurrentValues.SetValues(entidadActualizar);
            this.SaveChanges();
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
            this.Remove(entidadExistente);
            this.SaveChanges();
        }

        public void CargarEntidad(Type tipoEntidad, object entidadAgregar)
        {
            MethodInfo dbSetMethod = typeof(DbContext).GetMethod("Set", Type.EmptyTypes);
            MethodInfo dbSetGenericMethod = dbSetMethod.MakeGenericMethod(tipoEntidad);
            object dbSet = dbSetGenericMethod.Invoke(this, null);
            MethodInfo addMethod = dbSet.GetType().GetMethod("Add");
            addMethod.Invoke(dbSet, new object[] { entidadAgregar });
            this.SaveChanges();
        }

        public DbSet<C4_EN.Proyecto> Proyectos { get; set; }
        public DbSet<C4_EN.Servicio> Servicios { get; set; }
        public DbSet<C4_EN.Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entidadProyecto = modelBuilder.Entity<C4_EN.Proyecto>();
            entidadProyecto.ToTable("Proyectos");
            entidadProyecto.HasKey(e => e.Id);
            entidadProyecto.Property(e => e.Id).ValueGeneratedOnAdd();

            var entidadServicio = modelBuilder.Entity<C4_EN.Servicio>();
            entidadServicio.ToTable("Servicios");
            entidadServicio.HasKey(e => e.Id);
            entidadServicio.Property(e => e.Id).ValueGeneratedOnAdd();

            var entidadCliente = modelBuilder.Entity<C4_EN.Cliente>();
            entidadCliente.ToTable("Clientes");
            entidadCliente.HasKey(e => e.Id);
            entidadCliente.Property(e => e.Id).ValueGeneratedOnAdd();
        }
    }
}
