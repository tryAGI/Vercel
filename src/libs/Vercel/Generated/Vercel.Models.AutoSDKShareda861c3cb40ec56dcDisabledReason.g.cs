
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcDisabledReason
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
    public static class AutoSDKShareda861c3cb40ec56dcDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcDisabledReason value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShareda861c3cb40ec56dcDisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShareda861c3cb40ec56dcDisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShareda861c3cb40ec56dcDisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShareda861c3cb40ec56dcDisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShareda861c3cb40ec56dcDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShareda861c3cb40ec56dcDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShareda861c3cb40ec56dcDisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShareda861c3cb40ec56dcDisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShareda861c3cb40ec56dcDisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}