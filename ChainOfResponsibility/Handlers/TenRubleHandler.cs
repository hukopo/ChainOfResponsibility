namespace ChainOfResponsibility.Handlers
{
    public class TenRubleHandler : BanknoteHandlerBase
    {
        protected override CurrencyType CurrencyType => CurrencyType.Ruble;

        public TenRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 10;
    }
}