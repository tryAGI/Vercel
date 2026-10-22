
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0695a89a4e02b217DisabledReason
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
    public static class AutoSDKShared0695a89a4e02b217DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0695a89a4e02b217DisabledReason value)
        {
            return value switch
            {
                AutoSDKShared0695a89a4e02b217DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared0695a89a4e02b217DisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared0695a89a4e02b217DisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared0695a89a4e02b217DisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared0695a89a4e02b217DisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0695a89a4e02b217DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared0695a89a4e02b217DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShared0695a89a4e02b217DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared0695a89a4e02b217DisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared0695a89a4e02b217DisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared0695a89a4e02b217DisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}