﻿
using Destiny.Core.Flow.Exceptions;
using Destiny.Core.Flow.Extensions;
using Destiny.Core.Flow.MongoDB;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;


namespace Destiny.Core.Flow.MongoDB.DbContexts
{
    public abstract class MongoDbContextBase
    {
        private readonly MongoDbContextOptions _options;
        public MongoDbContextBase([NotNull] MongoDbContextOptions options) {
            _options = options;
        }

        private string ConnectionString => _options.ConnectionString;

        public IMongoDatabase Database => GetDbContext();

        public IMongoCollection<TEntity> Collection<TEntity>()
        {
            return Database.GetCollection<TEntity>(GetTableName<TEntity>());
        }

        private string GetTableName<TEntity>()
        {
            Type t = typeof(TEntity);
            var table = t.GetAttribute<MongoDBTableAttribute>();
            if (table == null)
                throw new AppException("Table name does not exist!");
            return table.TableName;
        }


        private IMongoDatabase GetDbContext()
        {
            var mongoUrl = new MongoUrl(ConnectionString);
            var databaseName = mongoUrl.DatabaseName;
            var database = new MongoClient(mongoUrl).GetDatabase(databaseName);
            return database;
        }
    }
}
