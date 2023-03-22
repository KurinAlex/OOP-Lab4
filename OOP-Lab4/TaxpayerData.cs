using System.Text;

namespace OOP_Lab4;

public record TaxpayerData(
	double MainJobIncome,
	double AdditionalJobIncome,
	double AuthorAwardsAmount,
	double GoodsSellsIncome,
	double MoneyGiftsAmount,
	double GoodsGiftsAmount,
	double AbroadTransfersAmount,
	int ChildrenCount)
{
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.AppendLine("Taxpayer data:");
		sb.AppendLine($"-> Main job income: {MainJobIncome}");
		sb.AppendLine($"-> Additional job income: {AdditionalJobIncome}");
		sb.AppendLine($"-> Author awards amount: {AuthorAwardsAmount}");
		sb.AppendLine($"-> Goods sells income: {GoodsSellsIncome}");
		sb.AppendLine($"-> Money gifts amount: {MoneyGiftsAmount}");
		sb.AppendLine($"-> Abroad transfers amount: {AbroadTransfersAmount}");
		sb.AppendLine($"-> Children count: {ChildrenCount}");
		return sb.ToString();
	}
}
