﻿namespace PlayersAndMonsters.Core.Factories
{
    using PlayersAndMonsters.Core.Factories.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories;

    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            IPlayer player = null;
            if (type == "Beginner")
            {
                player = new Beginner(new CardRepository(), username);
            }
            else if (type == "Advanced")
            {
                player = new Advanced(new CardRepository(), username);
            }

            return player;
        }
    }
}
