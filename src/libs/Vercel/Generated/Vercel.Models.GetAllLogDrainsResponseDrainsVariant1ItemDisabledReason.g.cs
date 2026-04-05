
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllLogDrainsResponseDrainsVariant1ItemDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason.DisabledByAdmin => "disabled-by-admin",
                GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason.DisabledByOwner => "disabled-by-owner",
                GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason.FeatureNotAvailable => "feature-not-available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason.DisabledByOwner,
                "feature-not-available" => GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason.FeatureNotAvailable,
                _ => null,
            };
        }
    }
}