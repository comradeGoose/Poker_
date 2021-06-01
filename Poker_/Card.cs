namespace Poker
{
    public class Card
    {
        public enum Suit
        {
            Черви = 1,
            Трефы,
            Бубны,
            Пики
        }

        public enum Advantages
        {
            ace = 1,
            Двойка,
            Тройка,
            Четверка,
            Пятерка,
            Шестерка,
            Семерка,
            Восьмерка,
            Девятка,
            Десятка,
            Валет,
            Королева,
            Король
        }

        private Suit suit;
        private Advantages advantages;

        public Card(Suit suit, Advantages advantages)
        {
            this.suit = suit;
            this.advantages = advantages;
        }

        public override string ToString()
        {
            return $"{suit.ToString()} - {advantages.ToString()}";
        }
    }
}