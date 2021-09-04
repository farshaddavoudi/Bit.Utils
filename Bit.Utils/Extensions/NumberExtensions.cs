namespace Bit.Utils.Extensions
{
    public static class NumberExtensions
    {
        /// <summary>
        /// To Rial display with commas.
        /// 123456 => "123,123"
        /// </summary>
        /// <param name="moneyValue"></param>
        /// <param name="currencyDecimalAccuracyPoints"> For Rial it is zero </param>
        /// <returns></returns>
        public static string ToCurrencyStringFormat(this int moneyValue, int currencyDecimalAccuracyPoints = 0)
        {
            return moneyValue.ToString($"N{currencyDecimalAccuracyPoints}");
        }

        /// <summary>
        /// To Rial display with commas.
        /// 123456 => "123,123"
        /// </summary>
        /// <param name="moneyValue"></param>
        /// <param name="currencyDecimalAccuracyPoints"> For Rial it is zero </param>
        /// <returns></returns>
        public static string ToCurrencyStringFormat(this long moneyValue, int currencyDecimalAccuracyPoints = 0)
        {
            return moneyValue.ToString($"N{currencyDecimalAccuracyPoints}");
        }

    }
}