
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2DisabledReason
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
    public static class GetDrainResponseVariant2DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2DisabledReason value)
        {
            return value switch
            {
                GetDrainResponseVariant2DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                GetDrainResponseVariant2DisabledReason.DisabledByAdmin => "disabled-by-admin",
                GetDrainResponseVariant2DisabledReason.DisabledByOwner => "disabled-by-owner",
                GetDrainResponseVariant2DisabledReason.FeatureNotAvailable => "feature-not-available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => GetDrainResponseVariant2DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => GetDrainResponseVariant2DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => GetDrainResponseVariant2DisabledReason.DisabledByOwner,
                "feature-not-available" => GetDrainResponseVariant2DisabledReason.FeatureNotAvailable,
                _ => null,
            };
        }
    }
}