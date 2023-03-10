namespace CurrencyConverterLib;

public class Currency
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string CurrencyCode { get; set; }
    public string CurrencySymbol { get; set; }
    public Country Country { get; set; }
    public IEnumerable<ExchangeRate> ExchangeRates
    {
        get
        {
            return _exchangeRates;
        }
    }
    private List<ExchangeRate> _exchangeRates { get; set; }

    public void AddExchangeRate(ExchangeRate exchangeRate)
    {
        if (IsValid(exchangeRate))
        {
            _exchangeRates.Add(exchangeRate);
        }
    }

    private bool IsValid(ExchangeRate exchangeRate)
    {
        if (IsSameRateExist(exchangeRate))
        {
            return false;
        }

        return true;
    }

    private bool IsSameRateExist(ExchangeRate exchangeRate)
    {
        if (_exchangeRates
                .Where(u => u.Date == exchangeRate.Date)
                .FirstOrDefault(u => u.CurrencyPair.IsSame(exchangeRate.CurrencyPair)) == null)
        {
            return false;
        }

        return true;
    }
}