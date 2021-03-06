// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.co.uk/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Registered to: Simon Hughes
// Company      : Reverse POCO
// Licence Type : Commercial
// Licences     : 1
// Valid until  : 03 NOV 2020
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Connection String Name: "MyDbContext"
//     Connection String:      "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True;Application Name=Generator"
//     Multi-context settings: "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True;Application Name=Generator"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Developer Edition (64-bit)
// Database Engine Edition: Enterprise
// Database Version       : 14.0.2027.2

// <auto-generated>
// ReSharper disable CheckNamespace
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedVariable
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantCast
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// ReSharper disable UsePatternMatching
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Spatial;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace EfrpgCopy
{
    #region Database context interface

    public interface INorthwindTest1 : IDisposable
    {
        DbSet<AbcPluralTest> AlphabeticalPluralTests { get; set; } // Alphabetical list of products
        DbSet<Category> Categories { get; set; } // Categories
        DbSet<Product> Products { get; set; } // Products

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbChangeTracker ChangeTracker { get; }
        DbContextConfiguration Configuration { get; }
        Database Database { get; }
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbEntityEntry Entry(object entity);
        IEnumerable<DbEntityValidationResult> GetValidationErrors();
        DbSet Set(Type entityType);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

    #endregion

    #region Database context

    public class NorthwindTest1 : DbContext, INorthwindTest1
    {
        public DbSet<AbcPluralTest> AlphabeticalPluralTests { get; set; } // Alphabetical list of products
        public DbSet<Category> Categories { get; set; } // Categories
        public DbSet<Product> Products { get; set; } // Products

        static NorthwindTest1()
        {
            System.Data.Entity.Database.SetInitializer<NorthwindTest1>(null);
        }

        /// <inheritdoc />
        public NorthwindTest1()
            : base("Name=MyDbContext")
        {
        }

        /// <inheritdoc />
        public NorthwindTest1(string connectionString)
            : base(connectionString)
        {
        }

        /// <inheritdoc />
        public NorthwindTest1(string connectionString, DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        /// <inheritdoc />
        public NorthwindTest1(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        /// <inheritdoc />
        public NorthwindTest1(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        /// <inheritdoc />
        public NorthwindTest1(ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AbcPluralTestConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());

            // Indexes        
            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryID)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("PK_Categories", 1) { IsUnique = true, IsClustered = true })
                );


            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("CategoryName", 1))
                );


            modelBuilder.Entity<Product>()
                .Property(e => e.ProductId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("PK_Products", 1) { IsUnique = true, IsClustered = true })
                );


            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("ProductName", 1))
                );

        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AbcPluralTestConfiguration(schema));
            modelBuilder.Configurations.Add(new CategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductConfiguration(schema));

            return modelBuilder;
        }
    }

    #endregion

    #region Database context factory

    public class NorthwindTest1Factory : IDbContextFactory<NorthwindTest1>
    {
        public NorthwindTest1 Create()
        {
            return new NorthwindTest1();
        }
    }

    #endregion

    #region Fake Database context

    public class FakeNorthwindTest1 : INorthwindTest1
    {
        public DbSet<AbcPluralTest> AlphabeticalPluralTests { get; set; } // Alphabetical list of products
        public DbSet<Category> Categories { get; set; } // Categories
        public DbSet<Product> Products { get; set; } // Products

        public FakeNorthwindTest1()
        {
            _changeTracker = null;
            _configuration = null;
            _database = null;

            AlphabeticalPluralTests = new FakeDbSet<AbcPluralTest>("ProductKEY");
            Categories = new FakeDbSet<Category>("CategoryID");
            Products = new FakeDbSet<Product>("ProductId");

        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return Task<int>.Factory.StartNew(() => 1);
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private DbChangeTracker _changeTracker;

        public DbChangeTracker ChangeTracker { get { return _changeTracker; } }

        private DbContextConfiguration _configuration;

        public DbContextConfiguration Configuration { get { return _configuration; } }

        private Database _database;

        public Database Database { get { return _database; } }

        public DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public DbEntityEntry Entry(object entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DbEntityValidationResult> GetValidationErrors()
        {
            throw new NotImplementedException();
        }

        public DbSet Set(Type entityType)
        {
            throw new NotImplementedException();
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region Fake DbSet

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    public class FakeDbSet<TEntity> : DbSet<TEntity>, IQueryable, IEnumerable<TEntity>, IDbAsyncEnumerable<TEntity> where TEntity : class
    {
        private readonly PropertyInfo[] _primaryKeys;
        private readonly ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;

        public FakeDbSet()
        {
            _data = new ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public FakeDbSet(params string[] primaryKeys)
        {
            _primaryKeys = typeof(TEntity).GetProperties().Where(x => primaryKeys.Contains(x.Name)).ToArray();
            _data = new ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public override TEntity Find(params object[] keyValues)
        {
            if (_primaryKeys == null)
                throw new ArgumentException("No primary keys defined");
            if (keyValues.Length != _primaryKeys.Length)
                throw new ArgumentException("Incorrect number of keys passed to Find method");

            var keyQuery = this.AsQueryable();
            keyQuery = keyValues
                .Select((t, i) => i)
                .Aggregate(keyQuery,
                    (current, x) =>
                        current.Where(entity => _primaryKeys[x].GetValue(entity, null).Equals(keyValues[x])));

            return keyQuery.SingleOrDefault();
        }

        public override Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
        {
            return Task<TEntity>.Factory.StartNew(() => Find(keyValues), cancellationToken);
        }

        public override Task<TEntity> FindAsync(params object[] keyValues)
        {
            return Task<TEntity>.Factory.StartNew(() => Find(keyValues));
        }

        public override IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }

        public override TEntity Add(TEntity item)
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override IEnumerable<TEntity> RemoveRange(IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Remove(entity);
            }
            return items;
        }

        public override TEntity Remove(TEntity item)
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Remove(item);
            return item;
        }

        public override TEntity Attach(TEntity item)
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override TEntity Create()
        {
            return Activator.CreateInstance<TEntity>();
        }

        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }

        public override ObservableCollection<TEntity> Local
        {
            get { return _data; }
        }

        Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<TEntity> IEnumerable<TEntity>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IDbAsyncEnumerator<TEntity> IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator());
        }
    }

    public class FakeDbAsyncQueryProvider<TEntity> : IDbAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public FakeDbAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            var m = expression as MethodCallExpression;
            if (m != null)
            {
                var resultType = m.Method.ReturnType; // it should be IQueryable<T>
                var tElement = resultType.GetGenericArguments()[0];
                var queryType = typeof(FakeDbAsyncEnumerable<>).MakeGenericType(tElement);
                return (IQueryable) Activator.CreateInstance(queryType, expression);
            }
            return new FakeDbAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            var queryType = typeof(FakeDbAsyncEnumerable<>).MakeGenericType(typeof(TElement));
            return (IQueryable<TElement>) Activator.CreateInstance(queryType, expression);
        }

        public object Execute(Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public Task<object> ExecuteAsync(Expression expression, CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute(expression));
        }

        public Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute<TResult>(expression));
        }
    }

    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, IDbAsyncEnumerable<T>, IQueryable<T>
    {
        public FakeDbAsyncEnumerable(IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public FakeDbAsyncEnumerable(Expression expression)
            : base(expression)
        { }

        public IDbAsyncEnumerator<T> GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        IDbAsyncEnumerator IDbAsyncEnumerable.GetAsyncEnumerator()
        {
            return GetAsyncEnumerator();
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<T>(this); }
        }

    }

    public class FakeDbAsyncEnumerator<T> : IDbAsyncEnumerator<T>
    {
        private readonly IEnumerator<T> _inner;

        public FakeDbAsyncEnumerator(IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public Task<bool> MoveNextAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(_inner.MoveNext());
        }

        public T Current
        {
            get { return _inner.Current; }
        }

        object IDbAsyncEnumerator.Current
        {
            get { return Current; }
        }
    }

    #endregion

    #region POCO classes

    // Alphabetical list of products
    // List of products used by Northwind
    public class AbcPluralTest
    {
        public int ProductKEY { get; set; } // ProductID (Primary key)
        public string ProductName { get; set; } // ProductName (length: 40)
        public decimal? Price { get; set; } // UnitPrice
    }

    // Categories
    public class Category
    {
        public int CategoryID { get; set; } // CategoryID (Primary key)
        public string CategoryName { get; set; } // CategoryName (length: 15)

        // Reverse navigation

        /// <summary>
        /// Child Products where [Products].[CategoryID] point to this entity (FK_Products_Categories)
        /// </summary>
        public virtual ICollection<Product> Products { get; set; } // Products.FK_Products_Categories

        public Category()
        {
            Products = new List<Product>();
        }
    }

    // Products
    public class Product
    {
        public int ProductId { get; set; } // ProductID (Primary key)
        public string ProductName { get; set; } // ProductName (length: 40)

        // Foreign keys

        /// <summary>
        /// Parent Category pointed by [Products].([CategoryId]) (FK_Products_Categories)
        /// </summary>
        public virtual Category Category { get; set; } // FK_Products_Categories
    }


    #endregion

    #region POCO Configuration

    // Alphabetical list of products
    // List of products used by Northwind
    public class AbcPluralTestConfiguration : EntityTypeConfiguration<AbcPluralTest>
    {
        public AbcPluralTestConfiguration()
            : this("dbo")
        {
        }

        public AbcPluralTestConfiguration(string schema)
        {
            ToTable("Alphabetical list of products", schema);
            HasKey(x => x.ProductKEY);

            Property(x => x.ProductKEY).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductName).HasColumnName(@"ProductName").HasColumnType("nvarchar").IsRequired().HasMaxLength(40);
            Property(x => x.Price).HasColumnName(@"UnitPrice").HasColumnType("money").IsOptional().HasPrecision(19,4);
        }
    }

    // Categories
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
            : this("dbo")
        {
        }

        public CategoryConfiguration(string schema)
        {
            ToTable("Categories", schema);
            HasKey(x => x.CategoryID);

            Property(x => x.CategoryID).HasColumnName(@"CategoryID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CategoryName).HasColumnName(@"CategoryName").HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
        }
    }

    // Products
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
            : this("dbo")
        {
        }

        public ProductConfiguration(string schema)
        {
            ToTable("Products", schema);
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductName).HasColumnName(@"ProductName").HasColumnType("nvarchar").IsRequired().HasMaxLength(40);
        }
    }


    #endregion

}
// </auto-generated>

