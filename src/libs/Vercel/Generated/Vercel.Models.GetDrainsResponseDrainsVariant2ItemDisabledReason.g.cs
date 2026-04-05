
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemDisabledReason
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
    public static class GetDrainsResponseDrainsVariant2ItemDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemDisabledReason value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                GetDrainsResponseDrainsVariant2ItemDisabledReason.DisabledByAdmin => "disabled-by-admin",
                GetDrainsResponseDrainsVariant2ItemDisabledReason.DisabledByOwner => "disabled-by-owner",
                GetDrainsResponseDrainsVariant2ItemDisabledReason.FeatureNotAvailable => "feature-not-available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => GetDrainsResponseDrainsVariant2ItemDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => GetDrainsResponseDrainsVariant2ItemDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => GetDrainsResponseDrainsVariant2ItemDisabledReason.DisabledByOwner,
                "feature-not-available" => GetDrainsResponseDrainsVariant2ItemDisabledReason.FeatureNotAvailable,
                _ => null,
            };
        }
    }
}