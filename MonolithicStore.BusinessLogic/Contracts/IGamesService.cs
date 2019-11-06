using MonolithicStore.BusinessLogic.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicStore.BusinessLogic.Contracts
{
    [ServiceContract]
    public interface IGamesService
    {
        [OperationContract]
        ICollection<GameDto> GetGames();
    }
}