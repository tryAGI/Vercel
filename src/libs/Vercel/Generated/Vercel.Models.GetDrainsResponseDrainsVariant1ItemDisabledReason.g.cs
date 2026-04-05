
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemDisabledReason
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
    public static class GetDrainsResponseDrainsVariant1ItemDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemDisabledReason value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                GetDrainsResponseDrainsVariant1ItemDisabledReason.DisabledByAdmin => "disabled-by-admin",
                GetDrainsResponseDrainsVariant1ItemDisabledReason.DisabledByOwner => "disabled-by-owner",
                GetDrainsResponseDrainsVariant1ItemDisabledReason.FeatureNotAvailable => "feature-not-available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => GetDrainsResponseDrainsVariant1ItemDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => GetDrainsResponseDrainsVariant1ItemDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => GetDrainsResponseDrainsVariant1ItemDisabledReason.DisabledByOwner,
                "feature-not-available" => GetDrainsResponseDrainsVariant1ItemDisabledReason.FeatureNotAvailable,
                _ => null,
            };
        }
    }
}