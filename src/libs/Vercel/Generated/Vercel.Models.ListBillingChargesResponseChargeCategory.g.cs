
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Classification of the charge
    /// </summary>
    public enum ListBillingChargesResponseChargeCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Adjustment,
        /// <summary>
        /// 
        /// </summary>
        Credit,
        /// <summary>
        /// 
        /// </summary>
        Purchase,
        /// <summary>
        /// 
        /// </summary>
        Tax,
        /// <summary>
        /// 
        /// </summary>
        Usage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBillingChargesResponseChargeCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBillingChargesResponseChargeCategory value)
        {
            return value switch
            {
                ListBillingChargesResponseChargeCategory.Adjustment => "Adjustment",
                ListBillingChargesResponseChargeCategory.Credit => "Credit",
                ListBillingChargesResponseChargeCategory.Purchase => "Purchase",
                ListBillingChargesResponseChargeCategory.Tax => "Tax",
                ListBillingChargesResponseChargeCategory.Usage => "Usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBillingChargesResponseChargeCategory? ToEnum(string value)
        {
            return value switch
            {
                "Adjustment" => ListBillingChargesResponseChargeCategory.Adjustment,
                "Credit" => ListBillingChargesResponseChargeCategory.Credit,
                "Purchase" => ListBillingChargesResponseChargeCategory.Purchase,
                "Tax" => ListBillingChargesResponseChargeCategory.Tax,
                "Usage" => ListBillingChargesResponseChargeCategory.Usage,
                _ => null,
            };
        }
    }
}