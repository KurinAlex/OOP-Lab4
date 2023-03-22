namespace OOP_Lab4;

public abstract class Tax : IComparable<Tax>
{
	private readonly double _amount;

	public Tax(TaxpayerData taxpayerData)
	{
		double taxedAmount = GetTaxedAmount(taxpayerData);
		_amount = Math.Max(0.0, taxedAmount * Percent / 100.0);
	}

	public double Amount => _amount;
	public abstract string Name { get; }
	protected abstract double Percent { get; }

	protected abstract double GetTaxedAmount(TaxpayerData taxpayerData);
	public int CompareTo(Tax? other) => _amount.CompareTo(other?._amount);
	public override string ToString() => $"{Name} tax: {_amount}";
}
