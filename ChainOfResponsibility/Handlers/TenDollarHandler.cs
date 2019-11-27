namespace ChainOfResponsibility.Handlers
{
    public class TenDollarHandler : BanknoteHandlerBase
    {
        protected override CurrencyType CurrencyType => CurrencyType.Dollar;
        protected override int Value => 10;

        public TenDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}