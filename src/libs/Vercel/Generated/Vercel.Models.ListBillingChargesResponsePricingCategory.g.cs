
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Pricing model used for the charge.
    /// </summary>
    public enum ListBillingChargesResponsePricingCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Committed,
        /// <summary>
        /// 
        /// </summary>
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBillingChargesResponsePricingCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBillingChargesResponsePricingCategory value)
        {
            return value switch
            {
                ListBillingChargesResponsePricingCategory.Committed => "Committed",
                ListBillingChargesResponsePricingCategory.Dynamic => "Dynamic",
                ListBillingChargesResponsePricingCategory.Other => "Other",
                ListBillingChargesResponsePricingCategory.Standard => "Standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBillingChargesResponsePricingCategory? ToEnum(string value)
        {
            return value switch
            {
                "Committed" => ListBillingChargesResponsePricingCategory.Committed,
                "Dynamic" => ListBillingChargesResponsePricingCategory.Dynamic,
                "Other" => ListBillingChargesResponsePricingCategory.Other,
                "Standard" => ListBillingChargesResponsePricingCategory.Standard,
                _ => null,
            };
        }
    }
}