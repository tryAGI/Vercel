
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2bfc0b0e9e85f636DisabledReason
    {
        /// <summary>
        ///
        /// </summary>
        AccountPlanDowngrade,
        /// <summary>
        ///
        /// </summary>
        DisabledByAdmin,
        /// <summary>
        ///
        /// </summary>
        DisabledByOwner,
        /// <summary>
        ///
        /// </summary>
        FeatureNotAvailable,
        /// <summary>
        ///
        /// </summary>
        LimitsExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2bfc0b0e9e85f636DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2bfc0b0e9e85f636DisabledReason value)
        {
            return value switch
            {
                AutoSDKShared2bfc0b0e9e85f636DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared2bfc0b0e9e85f636DisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared2bfc0b0e9e85f636DisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared2bfc0b0e9e85f636DisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared2bfc0b0e9e85f636DisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2bfc0b0e9e85f636DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared2bfc0b0e9e85f636DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShared2bfc0b0e9e85f636DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared2bfc0b0e9e85f636DisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared2bfc0b0e9e85f636DisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared2bfc0b0e9e85f636DisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}