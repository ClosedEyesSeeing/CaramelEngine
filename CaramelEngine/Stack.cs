using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine
{
    // Note: The ActionStack is pretty solid. It does it's basic job.
    // the client will handle when things need to push or pop.
    // Since actions will do just about anything, this will probably
    // also end up being used to facilitate semi-realtime actions.
    // ie: Think SW:KotoR - you can queue 'moves' you want to do whilest attacking

    public class ActionStack
    {
        private List<CaramelEngine.Action> _StackedActions;
        public int StackCount { get { return _StackedActions.Count; } }
        
        public List<CaramelEngine.Action> StackedActions
        {
            get
            {
                List<Action> aList = new List<CaramelEngine.Action>();
                foreach (CaramelEngine.Action a in _StackedActions)
                    aList.Add(a);
                return aList;
            }            
        }


        public ActionStack()
        {
            _StackedActions = new List<CaramelEngine.Action>();            
        }

        public void AddToStack(CaramelEngine.Action action)
        {
            _StackedActions.Insert(0, action);
        }

        // TODO: See if I want to perform the action here, or on the client side.
        public CaramelEngine.Action ResloveAction()
        {
            CaramelEngine.Action a = _StackedActions[0];            
            _StackedActions.Remove(a);
            return a;
        }

        public List<CaramelEngine.Action> ResolveStack()
        {
            List<CaramelEngine.Action> aList = new List<CaramelEngine.Action>();
            foreach (CaramelEngine.Action a in _StackedActions)
                aList.Add(a);
            _StackedActions.Clear();
            return aList;
        }
    }
}
