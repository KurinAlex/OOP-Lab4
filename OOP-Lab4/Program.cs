namespace OOP_Lab4;

public static class Program
{
	static readonly Random rand = new();
	static double NextDouble(double max) => rand.NextDouble() * max;
	static void WriteArray<T>(T[] arr) => Array.ForEach(arr, i => Console.WriteLine($"-> {i}"));
	static TaxpayerData GenerateTaxpayerData() =>
		new(
			MainJobIncome: NextDouble(50000.0),
			AdditionalJobIncome: NextDouble(30000.0),
			AuthorAwardsAmount: NextDouble(10000.0),
			GoodsSellsIncome: NextDouble(20000.0),
			MoneyGiftsAmount: NextDouble(10000.0),
			GoodsGiftsAmount: NextDouble(15000.0),
			AbroadTransfersAmount: NextDouble(40000.0),
			ChildrenCount: rand.Next(10)
		);

	static void Main()
	{
		var taxpayerData = GenerateTaxpayerData();
		Console.WriteLine(taxpayerData);

		var taxes = new Tax[]
		{
			new AbroadTransfersTax(taxpayerData),
			new GiftsTax(taxpayerData),
			new GoodsTax(taxpayerData),
			new JobTax(taxpayerData),
			new MilitaryTax(taxpayerData)
		};

		Console.WriteLine("Taxes array before sort:");
		WriteArray(taxes);
		Console.WriteLine();

		Console.WriteLine("Taxes array after sort:");
		Array.Sort(taxes);
		WriteArray(taxes);

		Console.ReadLine();
	}
}