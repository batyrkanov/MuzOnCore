using System;
using System.Collections.Generic;
using System.Text;

namespace MuzOnCore.Services.Query
{
    public class QueryResponse<T>
    {
        public IList<T> Data { get; set; }
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
    }
}
