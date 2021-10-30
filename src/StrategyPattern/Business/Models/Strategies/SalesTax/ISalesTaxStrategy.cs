namespace StrategyPattern.Business;
public interface ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order);
}