using System;
using System.Collections.Generic;
using System.Text;

namespace MuzOnCore.Services.Query
{
    public class QueryRequest<TSortType>
    {
        public int? Start { get; set; }
        public int? Length { get; set; }
        public QuerySearch Search { get; set; }
        public IEnumerable<QueryOrder<TSortType>> OrderQueries { get; set; }
        public IEnumerable<string> Includes { get; set; }
    }
}
