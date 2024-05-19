using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine
{
    // Notes:
    /* Cards have: Abilities.
     * Abilities have: Actions.
     * Actions go on the stack.
     * Actions have one method, "PerformAction" which will vary from
     * action to action.
     */

    // TODO: Change Abilities to have multiple actions.
    // TODO: Create 'preset/base' actions that can be used on client side
    // implementations. Example: DamageTargetPlayerForX(Player targetPlayer, Int xDamage)
    // this could then be used to make any damage spell, ie "Causes 2 damage to all players" or "Attack for 1 damage"
    // Need a breadth of 'base' actions for the client to use and expand upon.

    public interface IAction<T> where T : IGenericTarget
    {
        Guid ID { get; set; }
        T Target { get; set; }
    }
    
    public class Action : IAction<IGenericTarget>
    {        
        #region IAction<IGenericTarget> Members

        Guid ID
        {
            get;
            set;
        }

        public IGenericTarget Target
        {
            get;
            set;
        }

        #endregion

        public delegate object PerformActionDelegate(object param);

        internal PerformActionDelegate DelegateAction;

        public object PerformAction(object param)
        {
            return DelegateAction(param);            
        }

        public object PerformAction()
        {
            return DelegateAction(null);
        }

        public Action(PerformActionDelegate performActionDelegate)
        {
            DelegateAction = performActionDelegate;
        }

        #region IAction<IGenericTarget> Members

        Guid IAction<IGenericTarget>.ID
        {
            get;
            set;
        }

        #endregion
    }

    public interface IAbility
    {
        string Name { get; set; }
        string Text { get; set; }
        Action Action { get; set; }
    }
    public class Ability : IAbility
    {
        Guid ID { get; set; }

        #region IAbility Members

        public string Name
        {
            get;
            set;
        }

        public string Text
        {
            get;
            set;
        }

        public Action Action
        {
            get;
            set;
        }

        #endregion
    }
    
    /*public class Action
    {
        public Guid ID { get; set; }
        //public Card Caller { get; set; }
        //public bool isCounterBased { get; set; }
        //public int MinCounter { get; set; }
        //public int MaxCounter { get; set; }

        //public void AttackPlayersForAmount(List<Player> playerList, int damageAmt)
        //{
        //    foreach (Player p in playerList)
        //    {
        //        if (p.Resources.LifePointsMinValue != null)
        //        {
        //            int tempamt = p.Resources.LifePoints - damageAmt;
        //            if (tempamt < p.Resources.LifePointsMinValue)
        //                p.Resources.LifePoints = p.Resources.LifePointsMinValue;
        //            else
        //                p.Resources.LifePoints -= damageAmt;
        //        }
        //        else
        //            p.Resources.LifePoints -= damageAmt;
        //    }
        //}

        //public void HealPlayersForAmount(List<Player> playerList, int damageAmt)
        //{
        //    foreach (Player p in playerList)
        //    {
        //        if (p.Resources.LifePointsMaxValue != null)
        //        {
        //            int tempamt = p.Resources.LifePoints + damageAmt;
        //            if (tempamt > p.Resources.LifePointsMaxValue)
        //                p.Resources.LifePoints = p.Resources.LifePointsMaxValue;
        //            else
        //                p.Resources.LifePoints += damageAmt;
        //        }
        //        else
        //            p.Resources.LifePoints += damageAmt;
        //    }
        //}

        //public void AddCounter()
        //{
        //    if (Caller != null)
        //    {
        //        int tempCounter = Caller.Counter + 1;
        //        if (isCounterBased)
        //        {
        //            if (tempCounter > MaxCounter)
        //                return;
        //            else
        //                Caller.Counter++;
        //        }
        //        else
        //            Caller.Counter++;
        //    }
        //}
        //public void RemoveCounter()
        //{
        //    if (Caller != null)
        //    {
        //        int tempCounter = Caller.Counter - 1;
        //        if (isCounterBased)
        //        {
        //            if (tempCounter < MinCounter)
        //                return;
        //            else
        //                Caller.Counter--;
        //        }
        //        else
        //            Caller.Counter--;
        //    }
        //}
        //public void AddCounter(int byVal)
        //{
        //    if (Caller != null)
        //    {
        //        int tempCounter = Caller.Counter + byVal;
        //        if (isCounterBased)
        //        {
        //            if (tempCounter > MaxCounter)
        //                return;
        //            else
        //                Caller.Counter += byVal;
        //        }
        //        else
        //            Caller.Counter += byVal;
        //    }
        //}
        //public void RemoveCounter(int byVal)
        //{
        //    if (Caller != null)
        //    {
        //        int tempCounter = Caller.Counter - byVal;
        //        if (isCounterBased)
        //        {
        //            if (tempCounter < MinCounter)
        //                return;
        //            else
        //                Caller.Counter -= byVal;
        //        }
        //        else
        //            Caller.Counter -= byVal;
        //    }
        //}

        ////public void IncreaseDiceMinValue(int byVal, Territory t)
        ////{
        ////    // TODO: Dice Modify Min Player set
        ////}

        //public Action()
        //{
        //    ID = Guid.NewGuid();
        //}        
    }*/

}
