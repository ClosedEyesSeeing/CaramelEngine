using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CaramelEngine.Interfaces;

namespace CaramelEngine
{

    // NOTE: Players are generically done for now.
    // TODO: Need some 'preset/base' player configurations


    public class Player : IPlayer
    {
        public Player(string _UserName, bool _isUser)
        {
            Id = Guid.NewGuid();
            UserName = _UserName;
            isUser = _isUser;
        }

        #region IPlayer Members

        public Guid Id
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
