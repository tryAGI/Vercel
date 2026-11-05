
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the row's cost was split between teams. `uncalibrated_estimate` divides billed usage by each team's usage share; `calibrated_estimate` also scales each team to its rated cycle subtotal. Null on rows not split between teams. Product and day totals are billed amounts either way.
    /// </summary>
    public enum ListBillingChargesResponseXCostAttribution
    {
        /// <summary>
        ///
        /// </summary>
        CalibratedEstimate,
        /// <summary>
        ///
        /// </summary>
        UncalibratedEstimate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBillingChargesResponseXCostAttributionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBillingChargesResponseXCostAttribution value)
        {
            return value switch
            {
                ListBillingChargesResponseXCostAttribution.CalibratedEstimate => "calibrated_estimate",
                ListBillingChargesResponseXCostAttribution.UncalibratedEstimate => "uncalibrated_estimate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBillingChargesResponseXCostAttribution? ToEnum(string value)
        {
            return value switch
            {
                "calibrated_estimate" => ListBillingChargesResponseXCostAttribution.CalibratedEstimate,
                "uncalibrated_estimate" => ListBillingChargesResponseXCostAttribution.UncalibratedEstimate,
                _ => null,
            };
        }
    }
}