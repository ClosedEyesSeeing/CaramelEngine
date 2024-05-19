using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine
{

    // Note: The game board, It's pretty good as is.
    // TODO: 'preset/base' boards. These can be set up in all sorts of 
    // crazy and inventive ways, but lets lay down the basic ones.
    

    /* The game board. This is where I anticipate the action taking place.
     * ie. This controls which territories belong to which player
     * 1 player -> many Territories
     */
    public interface IBoard : IGenericTarget
    {
        Guid ID { get; set; }
        ActionStack Stack { get; set; }      
    }

    public class Board<T, P> : IBoard
    {        
        public Board()
        {
            ID = Guid.NewGuid();
        }

        public Board(List<T> _Territories, List<P> _Players)
        {
            ID = Guid.NewGuid();
            Players = _Players;
            Territories = _Territories;
            playerMapping = new Dictionary<P, List<T>>();
            foreach (P p in Players)
                playerMapping.Add(p, new List<T>());
        }

        /*        

        // returns the winning player
        public Player AttackTerritory(Player attackingPlayer, ColorTerritory attackingTerritory, ColorTerritory defendingTerritory)
        {
            if (!playerMapping[attackingPlayer].Contains(attackingTerritory))
                return null;
            if (playerMapping[attackingPlayer].Contains(attackingTerritory) && playerMapping[attackingPlayer].Contains(defendingTerritory))
                return null;


            int[] attackDefend = AttackDefend(attackingTerritory, defendingTerritory);
            while (attackDefend[0] == attackDefend[1])
                attackDefend = AttackDefend(attackingTerritory, defendingTerritory);

            if (attackDefend[0] > attackDefend[1])
                return attackingPlayer;
            else
            {
                foreach (Player p in Players)
                {
                    if (playerMapping[p].Contains(defendingTerritory))
                        return p;
                }
                return attackingPlayer;
            }
        }

        private int[] AttackDefend(Territory attackingTerritory, Territory defendingTerritory)
        {
            List<int> returnInts = new List<int>();
            Dice dice = new Dice();
            int attackingPoints = 0;
            foreach (int i in dice.RollD4(attackingTerritory.d4Count))
                attackingPoints += i;
            foreach (int i in dice.RollD6(attackingTerritory.d6Count))
                attackingPoints += i;
            foreach (int i in dice.RollD8(attackingTerritory.d8Count))
                attackingPoints += i;
            foreach (int i in dice.RollD10(attackingTerritory.d10Count))
                attackingPoints += i;
            foreach (int i in dice.RollD12(attackingTerritory.d12Count))
                attackingPoints += i;
            foreach (int i in dice.RollD20(attackingTerritory.d20Count))
                attackingPoints += i;

            int defendingPoints = 0;
            foreach (int i in dice.RollD4(defendingTerritory.d4Count))
                defendingPoints += i;
            foreach (int i in dice.RollD6(defendingTerritory.d6Count))
                defendingPoints += i;
            foreach (int i in dice.RollD8(defendingTerritory.d8Count))
                defendingPoints += i;
            foreach (int i in dice.RollD10(defendingTerritory.d10Count))
                defendingPoints += i;
            foreach (int i in dice.RollD12(defendingTerritory.d12Count))
                defendingPoints += i;
            foreach (int i in dice.RollD20(defendingTerritory.d20Count))
                defendingPoints += i;

            returnInts.Add(attackingPoints);
            returnInts.Add(defendingPoints);
            return returnInts.ToArray();
        }
        */

        #region IBoard<T> Members

        public Guid ID
        {
            get;
            set;
        }

        public List<T> Territories
        {
            get;
            set;
        }

        public List<P> Players
        {
            get;
            set;
        }

        public ActionStack Stack
        {
            get;
            set;
        }

        public Dictionary<P, List<T>> playerMapping
        {
            get;
            set;
        }

        #endregion

        public List<T> GetPlayerMapping(P player)
        {
            return playerMapping[player];
        }

        public bool AddPlayerToArea(P player, T area)
        {
            
            try
            {
                ClearAreaOfPlayers(area);
                playerMapping[player].Add(area);                     
                return true;
            }
            catch { return false; }
        }

        public bool UpdatePlayerAreas(P player, List<T> areas)
        {            
            try
            {
                foreach (T t in areas)
                    ClearAreaOfPlayers(t);
                playerMapping[player] = areas;                                     
                return true;
            }
            catch { return false; }
        }

        public bool RemovePlayerFromArea(P player, T area)
        {
            try
            {
                playerMapping[player].Remove(area);                
                return true;
            }
            catch { return false; }
        }

        public bool ClearAreaOfPlayers(T area)
        {
            try
            {
                foreach (P p in Players)
                {
                    if (playerMapping[p].Contains(area))
                        RemovePlayerFromArea(p, area);
                }
                return true;
            }
            catch { return false; }
        }
    }
    
}
