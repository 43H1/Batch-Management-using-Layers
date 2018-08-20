using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using BM.DAL.Properties;
using BM.DF;

namespace BM.DAL
{
    public class DatabaseContext
    { 
    public IMongoDatabase Database;
    public DatabaseContext()
    {
       var connectionString = Settings.Default.DBConnectionString;
       var settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
       var client = new MongoClient(settings);
       Database = client.GetDatabase(Settings.Default.DBName);
    }
        public IMongoCollection<Batch> Batches => Database.GetCollection<Batch>("batch");
    }
}
