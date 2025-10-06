using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Common.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {

        }
        public Category(int parentId, string name, int priorty)
        {
            İd = parentId;
            Name = name; 
            Priorty = priorty;
        }
        public required int ParentId { get; set; }
        public  string Name { get; set; }
        public int Priorty { get; set; }
    }
}
