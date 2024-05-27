using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CaramelEngine.Interfaces;

namespace CaramelEngine
{

    // TODO: Make a new class for 'preset/base' cards and decks.
    // this will facilitate quick implementations for people wanting
    // to see how this works. Take a stock deck and run with it.
    // To create a deck, you'll need cards, abilities and actions. (Which are available)

   
    public class Deck<T> : IDeck where T : ICard 
    {
        private List<T> CurrentCards { get; set; }
        public List<T> Cards { get; set; }

        public Deck()
        {
            Id = Guid.NewGuid();
            Cards = new List<T>();
            CurrentCards = new List<T>();
        }
        public Deck(List<T> cList)
        {
            Id = Guid.NewGuid();
            Cards = new List<T>();
            CurrentCards = new List<T>();
            Cards = cList;
            CurrentCards = cList;
        }

        public void ShuffleDeck()
        {
            if (Cards.Count <= 0)
                return;
            foreach (T t in Cards)
                CurrentCards.Add(t);
            foreach (T t in CurrentCards)
            {
                Random rand = new Random();
                CurrentCards.Remove(t);
                CurrentCards.Insert(rand.Next(0, CurrentCards.Count), t);
            }
        }

        public T DrawCard()
        {
            if (CurrentCards.Count > 0)
            {
                T card = CurrentCards[0];
                CurrentCards.RemoveAt(0);
                return card;
            }
            return default(T);
        }

        // TODO: Maybe put graveyard stuff in here

        public void DiscardXCards(int X)
        {
            while (X > 0)
            {
                try
                {
                    CurrentCards.RemoveAt(0);
                    X--;
                }
                catch { X = 0; }
            }
        }

        #region IDeck Members

        public Guid Id
        {
            get;
            set;
        }

        #endregion
    }

    public class ControlledDeck<T, P> : Deck<T>, IController<P>
        where T : ICard
        where P : ITargetable
    {

        public ControlledDeck(P player)
        {
            Owner = player;
            Controller = player;
        }
        public ControlledDeck(P player, List<T> cList)
            : base(cList)
        {
            Owner = player;
            Controller = player;
        }

        #region IController<P> Members

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

    public struct CardType
    {    
        public const string Benefit = "Benefit";
        public const string Summoning = "Summoning";
        public const string Attack = "Attack";
        public const string Counter = "Counter";        
    }


    public class Card : ICard
    {
        public Card(string _Name, string _Text)
        {
            this.Name = _Name;
            this.Text = _Text;
        }
        #region ICard Members

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

        public string Text
        {
            get;
            set;
        }

        #endregion
    }

    public class TypedCard : Card
    {
        public string CardType { get; set; }
        public TypedCard(string _Name, string _Text, string cardType)
            : base(_Name, _Text)
        {            
            CardType = cardType;
        }
    }

    public class TypedActionCard : TypedCard
    {
        public IEnumerable<Action> Action { get; set; }
        public TypedActionCard(string _Name, string _Text, string cardType, IEnumerable<Action> action)
            : base(_Name, _Text, cardType)
        {
            this.Action = action;
        }
    }

}
