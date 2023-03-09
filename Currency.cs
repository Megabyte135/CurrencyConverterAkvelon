namespace CurrencyConverterLib;

public class Currency
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string CurrencyCode { get; set; }
    public string CurrencySymbol { get; set; }
    public Country Country { get; set; }
    public List<ExchangeRate> ExchangeRates { get; set; }

    public void AddExchangeRate(ExchangeRate exchangeRate)
    {
        if (IsValid(exchangeRate))
        {
            ExchangeRates.Add(exchangeRate);
        }
    }

    private bool IsValid(ExchangeRate exchangeRate)
    {
        if (IsExist(exchangeRate))
        {
            return false;
        }

        return true;
    }

    private bool IsExist(ExchangeRate exchangeRate)
    {
        if (ExchangeRates
                .Where(u => u.Date == exchangeRate.Date)
                .FirstOrDefault(u => u.CurrencyPair.IsSame(exchangeRate.CurrencyPair)) == null)
        {
            return false;
        }

        return true;
    }
}