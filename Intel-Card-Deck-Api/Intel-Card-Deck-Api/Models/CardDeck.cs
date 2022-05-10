namespace Intel_Card_Deck_Api.Models
{
    public class CardDeck
    {
        public List<string>? Cards { get; set; }
        public string CardList { get; set; }
    }
    class Card : IComparable<Card>
    {
        public AllCards AllCards;

        public Card(AllCards allCards)
        {
            AllCards = allCards;
        }

        public int CompareTo(Card other)
        {
            if (AllCards > other.AllCards)
            {
                return 1;
            }
            if (AllCards < other.AllCards)
            {
                return -1;
            }
            return AllCards > other.AllCards ? 1 : -1;
        }

        public override string ToString()
        {
            return $"{AllCards}";
        }
    }

    enum AllCards
    {
        T4,
        T2,
        TS,
        TP,
        TR,
        D2,
        D3,
        D4,
        D5,
        D6,
        D7,
        D8,
        D9,
        D10,
        DJ,
        DQ,
        DK,
        DA,
        S2,
        S3,
        S4,
        S5,
        S6,
        S7,
        S8,
        S9,
        S10,
        SJ,
        SQ,
        SK,
        SA,
        C2,
        C3,
        C4,
        C5,
        C6,
        C7,
        C8,
        C9,
        C10,
        CJ,
        CQ,
        CK,
        CA,
        H2,
        H3,
        H4,
        H5,
        H6,
        H7,
        H8,
        H9,
        H10,
        HJ,
        HQ,
        HK,
        HA
    }
}
