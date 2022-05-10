using Intel_Card_Deck_Api.Models;

namespace Intel_Card_Deck_Api.Helpers
{
    public class CardDeckHelper
    {
        public static List<string> GetSortedCards(List<string> UnSortedCards)
        {
            List<string> SortedList = new List<string>();
            try
            {
                CardDeckClass cardDeck = new CardDeckClass(UnSortedCards);

                CardSorter sorter = new CardSorter();
                
                cardDeck.Sort(sorter);

                foreach(Card card in cardDeck.Cards)
                {
                    SortedList.Add(card.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }

            return SortedList;
        }
    }
    class CardSorter : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.AllCards > y.AllCards)
            {
                return 1;
            }
            if (x.AllCards < y.AllCards)
            {
                return -1;
            }
            return x.AllCards > y.AllCards ? 1 : -1;

        }
    }

    class CardDeckClass
    {
        public List<Card> Cards;

        public CardDeckClass(List<string> UnsortedCards)
        {
            Cards = new List<Card>();
          
            int numCards = UnsortedCards.Count;
            int matchingCard;

            for (int cardIndex = 0; cardIndex < numCards; cardIndex++)
            {
                matchingCard = (int)System.Enum.Parse(typeof(AllCards), UnsortedCards[cardIndex].ToString());

                Cards.Add(new Card((AllCards)matchingCard));                
            }
        }

        public int CountCardsInDeck => Cards.Count;
               

        public void Sort() => Cards.Sort();

        public void Sort(IComparer<Card> comparer) => Cards.Sort(comparer);

        public void WriteToConsole()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card);
            }
        }
    }

}
