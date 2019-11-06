using MonolithicStore.BusinessLogic.Contracts;
using MonolithicStore.BusinessLogic.DtoModels;
using MonolithicStore.DataAccess.Entities;
using MonolithicStore.DataAccess.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicStore.BusinessLogic.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class GamesService : IGamesService
    {
        private readonly IRepository<Game> gamesRepos;

        public GamesService(IRepository<Game> _gamesRepos)
        {
            gamesRepos = _gamesRepos;
        }

        public ICollection<GameDto> GetGames()
        {
            //select * from games inner join Genres ...
            var games = gamesRepos.GetAll(x=>x.Genres).ToList();

            var gamesDto = games.Select(x => new GameDto
            {
                Name = x.Name,
                Developer = x.Developer,
                Id = x.Id,
                Price = x.Price,
                Genres = x.Genres.Select(g => new GenreDto
                {
                    Name = g.Name,
                    Id = g.Id
                }).ToList()
            }).ToList();

            return gamesDto;
        }
    }
}
