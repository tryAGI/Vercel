
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemDisabledReason
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
    public static class GetAllLogDrainsResponseDrainsVariant2ItemDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemDisabledReason value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                GetAllLogDrainsResponseDrainsVariant2ItemDisabledReason.DisabledByAdmin => "disabled-by-admin",
                GetAllLogDrainsResponseDrainsVariant2ItemDisabledReason.DisabledByOwner => "disabled-by-owner",
                GetAllLogDrainsResponseDrainsVariant2ItemDisabledReason.FeatureNotAvailable => "feature-not-available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => GetAllLogDrainsResponseDrainsVariant2ItemDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => GetAllLogDrainsResponseDrainsVariant2ItemDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => GetAllLogDrainsResponseDrainsVariant2ItemDisabledReason.DisabledByOwner,
                "feature-not-available" => GetAllLogDrainsResponseDrainsVariant2ItemDisabledReason.FeatureNotAvailable,
                _ => null,
            };
        }
    }
}