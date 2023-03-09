namespace CurrencyConverterLib;

public class ExchangeRate
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public CurrencyPair CurrencyPair { get; set; }
    public float Rate { get; set; }

    public void SaveRate()
    {
        CurrencyPair.BaseCurrency.AddExchangeRate(this);
        CurrencyPair.CounterCurrency.AddExchangeRate(this);
    }
}