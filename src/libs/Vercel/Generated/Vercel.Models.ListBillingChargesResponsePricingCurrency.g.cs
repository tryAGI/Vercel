
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListBillingChargesResponsePricingCurrency
    {
        /// <summary>
        /// 
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBillingChargesResponsePricingCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBillingChargesResponsePricingCurrency value)
        {
            return value switch
            {
                ListBillingChargesResponsePricingCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBillingChargesResponsePricingCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => ListBillingChargesResponsePricingCurrency.Usd,
                _ => null,
            };
        }
    }
}