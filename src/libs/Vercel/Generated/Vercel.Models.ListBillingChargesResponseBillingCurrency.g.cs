
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Currency used for billing (ISO 4217)
    /// </summary>
    public enum ListBillingChargesResponseBillingCurrency
    {
        /// <summary>
        /// 
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBillingChargesResponseBillingCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBillingChargesResponseBillingCurrency value)
        {
            return value switch
            {
                ListBillingChargesResponseBillingCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBillingChargesResponseBillingCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => ListBillingChargesResponseBillingCurrency.Usd,
                _ => null,
            };
        }
    }
}