namespace ChainOfResponsibility.Handlers
{
    public class HundredDollarHandler : BanknoteHandlerBase
    {
        protected override CurrencyType CurrencyType => CurrencyType.Dollar;
        protected override int Value => 100;

        public HundredDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}