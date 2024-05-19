using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine
{

    // NOTE: Players are generically done for now.
    // TODO: Need some 'preset/base' player configurations

    public interface IPlayer : IGenericTarget
    {
      Guid ID { get; set; }
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
        //            if (t.Controller.ID == ID)
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
        //            if (t.Controller.ID == ID)
        //                counter++;
        //    }
        //    return counter;
        //}
    }
    public class Player : IPlayer
    {
        public Player(string _UserName, bool _isUser)
        {
            ID = Guid.NewGuid();
            UserName = _UserName;
            isUser = _isUser;
        }

        #region IPlayer Members

        public Guid ID
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }

        public bool isUser
        {
            get;
            set;
        }

        #endregion
    }        

    

}
