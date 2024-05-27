using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IPlayer : ITargetable
    {
        Guid Id { get; set; }
        //private string _userName;
        //private bool _systemPlayer;
        string UserName { get; set; }
        bool isUser { get; set; }

        //public List<Territory> GetPlayerTerritories(Board gameBoard)
        //{
        //    List<Territory> playerTerritories = new List<Territory>();
        //    foreach (Territory t in gameBoard.Territories)
        //    {
        //        if (t.Controller != null)
        //            if (t.Controller.Id == Id)
        //                playerTerritories.Add(t);
        //    }
        //    return playerTerritories;
        //}
        //public int GetPlayerTerritoriesCount(Board gameBoard)
        //{
        //    int counter = 0;
        //    foreach (Territory t in gameBoard.Territories)
        //    {
        //        if (t.Controller != null)
        //            if (t.Controller.Id == Id)
        //                counter++;
        //    }
        //    return counter;
        //}
    }
}
