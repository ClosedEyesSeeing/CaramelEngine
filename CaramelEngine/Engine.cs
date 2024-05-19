using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CaramelEngine
{
    // TODO: Rename this. This is no longer an 'engine' file.
    // this is more like a catch all for interfaces I didn't 
    // know where to put.

    // Created to allow for derived interface of Player, Territory or Board to be used in (where T :) clauses
    public interface IGenericTarget
    {
    }

    // Done.
    public interface IController<T>
    {
        T Owner { get; set; }
        T Controller { get; set; }
    }
    
    // Done.
    public interface IAttack<T>
    {
        // Note: Returns the Winner
        T Attack(T attack, T defend);
    }


    
    #region Preset/Base Classes

    
    public class StatPlayer : Player, IStats
    {
        
        public StatPlayer(string _UserName, bool _isUser)
            : base(_UserName, _isUser)
        {
        }

        
        #region IStats Members

        public int HealthPoints
        {
            get;
            set;
        }

        public int ManaPoints
        {
            get;
            set;
        }

        public int Currencey
        {
            get;
            set;
        }

        public int ArmorPoints
        {
            get;
            set;
        }

        public int Strength
        {
            get;
            set;
        }

        public int Stamina
        {
            get;
            set;
        }

        public int Intellect
        {
            get;
            set;
        }

        public int Agility
        {
            get;
            set;
        }

        public int ActionPoints
        {
            get;
            set;
        }
        #endregion
    }

    // Jerry TODO: So, below is going to be a class you'll use as a template to generate a class
    // for the engine. Take a look at it and play around with it.

    // Signature is public and of type class
    public class JerryTemplateClass // : BaseClass, IInterfaces
    {
        // Constructor
        public JerryTemplateClass()
        {
            // When constructing, set a variable local to this class to "Jerry"
            Name = "Jerry";

            // This is how you'd construct a new class in code elsewhere:
            JerryTemplateClass newJerryTemplate = new JerryTemplateClass();
            string test = newJerryTemplate.Name;

            // test in this case would Say Jerry because every time you create a new 
            // instance of this class, it'll always get set to Jerry.

        }

        // Properties
        public string Name { get; set; }
    }



    public class ColorTerritory<P> : Territory<ColorTerritory<P>, P>, IColor
    {
        private List<string> _colors = new List<string>();
        public List<string> Colors
        {
            get
            {
                _colors.Clear();
                if (Green > 0)
                    _colors.Add(Color.Green);
                if (Blue > 0)
                    _colors.Add(Color.Blue);
                if (Black > 0)
                    _colors.Add(Color.Black);
                if (Red > 0)
                    _colors.Add(Color.Red);
                if (White > 0)
                    _colors.Add(Color.White);
                if (Other > 0)
                    _colors.Add(Color.Other);
                return _colors;
            }
            set
            {
            }
        }

        public ColorTerritory()
            : base()
        {
        }
        public ColorTerritory(string tName)
            : base(tName)
        {
        }
        public ColorTerritory(string tName, int _Green, int _Blue, int _Black, int _Red, int _White, int _Other)
            : base(tName)
        {
            Green = _Green;
            Blue = _Blue;
            Black = _Black;
            Red = _Red;
            White = _White;
            Other = _Other;
        }

        #region IColor Members

        public int Green
        {
            get;
            set;
        }

        public int Red
        {
            get;
            set;
        }

        public int Blue
        {
            get;
            set;
        }

        public int Black
        {
            get;
            set;
        }

        public int White
        {
            get;
            set;
        }

        public int Other
        {
            get;
            set;
        }

        public void ClearColors()
        {
            Green = 0;
            Black = 0;
            Blue = 0;
            White = 0;
            Red = 0;
            Other = 0;
        }

        public int CountColors()
        {
            return Green + Black + Blue + Red + White + Other;
        }

        #endregion
    }

    public class DiceTerritory<P> : Territory<DiceTerritory<P>, P>, IDice
    {
        #region IDice Members

        public int diceCount
        {
            get { return d4Count + d6Count + d8Count + d10Count + d12Count + d20Count; }
        }

        public int d4Count
        {
            get;
            set;
        }

        public int d6Count
        {
            get;
            set;
        }

        public int d8Count
        {
            get;
            set;
        }

        public int d10Count
        {
            get;
            set;
        }

        public int d12Count
        {
            get;
            set;
        }

        public int d20Count
        {
            get;
            set;
        }

        #endregion
    }

    public class DiceColorTerritory<P> : ColorTerritory<P>, IDice
    {
        public DiceColorTerritory()
            : base()
        {
        }
        public DiceColorTerritory(string tName)
            : base(tName)
        {
        }
        public DiceColorTerritory(string tName, int _Green, int _Blue, int _Black, int _Red, int _White, int _Other)
            : base(tName)
        {
            Green = _Green;
            Blue = _Blue;
            Black = _Black;
            Red = _Red;
            White = _White;
            Other = _Other;
        }

        #region IDice Members

        public int diceCount
        {
            get { return d4Count + d6Count + d8Count + d10Count + d12Count + d20Count; }
        }

        public int d4Count
        {
            get;
            set;
        }

        public int d6Count
        {
            get;
            set;
        }

        public int d8Count
        {
            get;
            set;
        }

        public int d10Count
        {
            get;
            set;
        }

        public int d12Count
        {
            get;
            set;
        }

        public int d20Count
        {
            get;
            set;
        }

        #endregion
    }

    public class RestrictedDiceColorTerritory<P> : ColorTerritory<P>, IDice
    {
        private RestrictedDice diceRestrictions { get; set; }

        public RestrictedDiceColorTerritory(RestrictedDice _dice)
            : base()
        {
            diceRestrictions = _dice;
        }


        #region IDice Members

        public int diceCount
        {
            get { return d4Count + d6Count + d8Count + d10Count + d12Count + d20Count; }
        }

        public int d4Count
        {
            get { return diceRestrictions.d4Count; }
            set { diceRestrictions.d4Count = value; }
        }

        public int d6Count
        {
            get { return diceRestrictions.d6Count; }
            set { diceRestrictions.d6Count = value; }
        }

        public int d8Count
        {
            get { return diceRestrictions.d8Count; }
            set { diceRestrictions.d8Count = value; }
        }

        public int d10Count
        {
            get { return diceRestrictions.d10Count; }
            set { diceRestrictions.d10Count = value; }
        }

        public int d12Count
        {
            get { return diceRestrictions.d12Count; }
            set { diceRestrictions.d12Count = value; }
        }

        public int d20Count
        {
            get { return diceRestrictions.d20Count; }
            set { diceRestrictions.d20Count = value; }
        }

        #endregion
    }

    public class RestrictedDiceTerritory<P> : Territory<RestrictedDiceTerritory<P>, P>, IDice
    {
        private RestrictedDice diceRestrictions { get; set; }

        public RestrictedDiceTerritory(RestrictedDice _dice)
            : base()
        {
            diceRestrictions = _dice;
        }

        #region IDice Members

        public int diceCount
        {
            get { return d4Count + d6Count + d8Count + d10Count + d12Count + d20Count; }
        }

        public int d4Count
        {
            get { return diceRestrictions.d4Count; }
            set { diceRestrictions.d4Count = value; }
        }

        public int d6Count
        {
            get { return diceRestrictions.d6Count; }
            set { diceRestrictions.d6Count = value; }
        }

        public int d8Count
        {
            get { return diceRestrictions.d8Count; }
            set { diceRestrictions.d8Count = value; }
        }

        public int d10Count
        {
            get { return diceRestrictions.d10Count; }
            set { diceRestrictions.d10Count = value; }
        }

        public int d12Count
        {
            get { return diceRestrictions.d12Count; }
            set { diceRestrictions.d12Count = value; }
        }

        public int d20Count
        {
            get { return diceRestrictions.d20Count; }
            set { diceRestrictions.d20Count = value; }
        }

        #endregion
    }

    public enum TurnPhases
    {
        Null = 0,
        Upkeep = 1,
        Draw = 2,
        Battle = 3,
        Attack = 4,
        Defend = 5,
        EndPhase = 6,
        Cleanup = 7
    }

    public class GameBoard : Board<DiceColorTerritory<Player>, Player>, IAttack<DiceColorTerritory<Player>>
    {
        public Player CurrentPlayer { get; set; }
        public TurnPhases TurnPhase { get; set; }
        public Dictionary<Player, Reinforcement<Player>> PlayerReinforcements = new Dictionary<Player, Reinforcement<Player>>();
        public Dictionary<Player, Resources> ResourcePool = new Dictionary<Player, Resources>();
        public Dictionary<Player, Dice> PlayerDice = new Dictionary<Player, Dice>();
        public GameBoard()
            : base()
        {
        }
        public GameBoard(List<DiceColorTerritory<Player>> tList, List<Player> pList)
            : base(tList, pList)
        {
            PlayerReinforcements.Clear();
            ResourcePool.Clear();
            foreach (Player p in pList)
            {
                PlayerReinforcements.Add(p, new Reinforcement<Player>());
                ResourcePool.Add(p, new Resources());
            }
            TurnPhase = TurnPhases.Upkeep;
        }

        public DiceColorTerritory<Player> Attack(DiceColorTerritory<Player> attack, DiceColorTerritory<Player> defend)
        {
            int[] attackDefend = AttackDefend(attack, defend);
            while (attackDefend[0] == attackDefend[1])
                attackDefend = AttackDefend(attack, defend);

            if (attackDefend[0] > attackDefend[1])
            {
                AddPlayerToArea(attack.Owner, defend);
                defend.d4Count = (attack.d4Count > 0) ? attack.d4Count - 1 : 0;
                defend.d6Count = (attack.d6Count > 0) ? attack.d6Count - 1 : 0;
                defend.d8Count = (attack.d8Count > 0) ? attack.d8Count - 1 : 0;
                defend.d10Count = (attack.d10Count > 0) ? attack.d10Count - 1 : 0;
                defend.d12Count = (attack.d12Count > 0) ? attack.d12Count - 1 : 0;
                defend.d20Count = (attack.d20Count > 0) ? attack.d20Count - 1 : 0;
                attack.d4Count = (attack.d4Count > 0) ? 1 : 0;
                attack.d6Count = (attack.d6Count > 0) ? 1 : 0;
                attack.d8Count = (attack.d8Count > 0) ? 1 : 0;
                attack.d10Count = (attack.d10Count > 0) ? 1 : 0;
                attack.d12Count = (attack.d12Count > 0) ? 1 : 0;
                attack.d20Count = (attack.d20Count > 0) ? 1 : 0;
                return attack;
            }
            else
            {
                attack.d4Count = (attack.d4Count > 0) ? 1 : 0;
                attack.d6Count = (attack.d6Count > 0) ? 1 : 0;
                attack.d8Count = (attack.d8Count > 0) ? 1 : 0;
                attack.d10Count = (attack.d10Count > 0) ? 1 : 0;
                attack.d12Count = (attack.d12Count > 0) ? 1 : 0;
                attack.d20Count = (attack.d20Count > 0) ? 1 : 0;
                return defend;
            }
        }

        private int[] AttackDefend(DiceColorTerritory<Player> attackingTerritory, DiceColorTerritory<Player> defendingTerritory)
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

        new public bool AddPlayerToArea(Player p, DiceColorTerritory<Player> t)
        {
            base.AddPlayerToArea(p, t);
            t.Owner = p;
            t.Controller = p;
            return true;
        }
    }

    #endregion

}
