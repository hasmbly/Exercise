namespace Exercise.CommonCode.Accurate.InaccurateData.SampleCode
{
    public static class InaccurateDataSampleCode
    {
        public static void Run()
        {
            var itemTotalPrice = 14897721.000000;
            decimal itemTotalPriceToDecimal = 14897721.000000m;

            Console.WriteLine($"itemTotalPrice: {itemTotalPrice}");
            Console.WriteLine($"itemTotalPriceToDecimal: {itemTotalPriceToDecimal.RoundTwoDigitComma()}");
        }
    }
}