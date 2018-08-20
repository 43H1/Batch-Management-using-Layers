using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.DF
{
    public class Batch
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string BatchName { get; set; }
        public string StartDate { get; set; }
        public string TentativeEndDate { get; set; }
        public int TotalHours { get; set; }
        public int HoursTaken { get; set; }
        public List<Schedule> schedule = new List<Schedule>();
        public List<Associate> associate = new List<Associate>();
    }
}