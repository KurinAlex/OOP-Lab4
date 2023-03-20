﻿namespace OOP_Lab4;

public class AbroadTransfersTax : Tax
{
	public AbroadTransfersTax(TaxpayerData taxpayerData) : base(taxpayerData)
	{
	}

	protected override double Percent => 18.0;
	public override string Name => "Abroad transfers";

	protected override double GetTaxedAmount(TaxpayerData taxpayerData) => taxpayerData.AbroadTransfersAmount;
}
