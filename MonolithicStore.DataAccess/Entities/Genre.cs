using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicStore.DataAccess.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
