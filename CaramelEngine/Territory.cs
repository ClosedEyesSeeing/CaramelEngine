﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CaramelEngine.Interfaces;

namespace CaramelEngine
{

    // NOTE: Territories themselves are pretty good at the moment, I think.
    // TODO: We do need more types of territories made for the 'preset/base' items
    // TODO: Add Directional properties



    public class Territory<T, P> : ITerritory, IController<P>
    {        
        public List<T> ConnectedTerritories
        {
            get;
            set;
        }

        public List<T> TopTerritories { get; set; }
        public List<T> LeftTerritories { get; set; }
        public List<T> BottomTerritories { get; set; }
        public List<T> RightTerritories { get; set; }

        

        #region ITerritory Members

        public Guid Id
        {
            get;            
            set;            
        }

        public string Name
        {
            get;
            set;
        }        

        #endregion

        public Territory()
        {
            Id = Guid.NewGuid();            
            ConnectedTerritories = new List<T>(); // TODO: This needs to be evaluated for need.

            TopTerritories = new List<T>();
            LeftTerritories = new List<T>();
            BottomTerritories = new List<T>();
            RightTerritories = new List<T>();
        }

        public Territory(string territoryName)
        {
            Id = Guid.NewGuid();
            Name = territoryName;
            ConnectedTerritories = new List<T>(); // TODO: Evaluate need

            TopTerritories = new List<T>();
            LeftTerritories = new List<T>();
            BottomTerritories = new List<T>();
            RightTerritories = new List<T>();
        }

        #region IController<T> Members

        public P Owner
        {
            get;
            set;
        }

        public P Controller
        {
            get;
            set;
        }

        #endregion
    }
}
