using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicStore.DataAccess.Entities
{
    public class Game : BaseEntity
    {
        public string Name { get; set; }

        public string Developer { get; set; }

        public float Price { get; set; }

        public ICollection<Genre> Genres { get; set; }
    }
}