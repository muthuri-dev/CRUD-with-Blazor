
using newApp.Models;

namespace newApp;
public static class  GameClient{
    private static readonly List<Game> games = new(){
        new Game(){
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price  = 19.99M,
            ReleaseDate = new DateTime(1991,2,1)
        },
         new Game(){
            Id = 2,
            Name = "Street Fighter III",
            Genre = "Fighting",
            Price  = 21.99M,
            ReleaseDate = new DateTime(1991,2,1)
        },
         new Game(){
            Id = 3,
            Name = "Street Fighter IV",
            Genre = "Fighting",
            Price  = 25.99M,
            ReleaseDate = new DateTime(1991,2,1)
        },
         new Game(){
            Id = 4,
            Name = "Street Fighter V",
            Genre = "Fighting",
            Price  = 28.99M,
            ReleaseDate = new DateTime(1991,2,1)
        }
    };
    public static Game[] GetGames(){
        return games.ToArray();
    }
    public static void AddGame(Game game){
        game.Id = games.Max(game => game.Id) +1;
        games.Add(game);
    }
    public static Game GetGame(int Id){
        return games.Find(game =>game.Id == Id)?? throw new Exception("Could not find Game");
    }
    public static void UpdateGame(Game updateGame){
        Game existingGame = GetGame(updateGame.Id);
        existingGame.Name = updateGame.Name;
        existingGame.Genre  = updateGame.Genre;
        existingGame.Price = updateGame.Price;
        existingGame.ReleaseDate = updateGame.ReleaseDate;
    }
}
