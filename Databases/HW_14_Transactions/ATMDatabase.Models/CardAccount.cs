namespace ATMDatabase.Models
{
    public class CardAccount
    {
        public int Id { get; set; }

        public string CardNumber { get; set; }

        public string CardPIN { get; set; }

        public decimal CardCash { get; set; }
    }
}
