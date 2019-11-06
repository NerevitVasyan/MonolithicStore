using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicStore.BusinessLogic.DtoModels
{
    [DataContract(Name = "Game")]
    public class GameDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Developer { get; set; }

        [DataMember]
        public float Price { get; set; }

        [DataMember]
        public ICollection<GenreDto> Genres { get; set; }
    }
}
