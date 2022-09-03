using Calculator.Models.Enum;

namespace Calculator.Models
{
    public class Formula
    {
        public int ID { get; set; }
        public decimal Const1 { get; set; }
        public decimal Const2 { get; set; }
        public decimal Const3 { get; set; }
        public decimal Const4 { get; set; }
        public decimal Const5 { get; set; }
        public GenderEnum GenderID { get; set; }
        public Gender Gender { get; set; }
    }
}
