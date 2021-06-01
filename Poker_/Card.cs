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
            Король,
            Туз
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
