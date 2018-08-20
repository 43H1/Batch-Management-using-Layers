using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BM.DAL;
using MongoDB.Driver;

namespace BM.DF
{
    public class BatchService
    {
        private DatabaseContext ctx = new DatabaseContext();
        public IQueryable<Batch>GetBatches()
        {
            return ctx.Batches.AsQueryable();
        }
        public void AddItem(Batch batch)
        {
            ctx.Batches.InsertOne(batch);
        }
    }
}
