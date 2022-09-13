using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleVolunteerAPI.Domain.DTO
{
    public class RepositoryResponse<T> where T : class
    {
        public bool Result { get; set; }
        public int Count { get; set; }
        public T Entity { get; set; }
        public IList<T> Entities { get; set; }
        public Exception Error { get; set; }

        public RepositoryResponse()
        {
            Entities = new List<T>();
        }
    }
}
