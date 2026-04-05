
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant1DisabledReason
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
    public static class GetDrainResponseVariant1DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant1DisabledReason value)
        {
            return value switch
            {
                GetDrainResponseVariant1DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                GetDrainResponseVariant1DisabledReason.DisabledByAdmin => "disabled-by-admin",
                GetDrainResponseVariant1DisabledReason.DisabledByOwner => "disabled-by-owner",
                GetDrainResponseVariant1DisabledReason.FeatureNotAvailable => "feature-not-available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant1DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => GetDrainResponseVariant1DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => GetDrainResponseVariant1DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => GetDrainResponseVariant1DisabledReason.DisabledByOwner,
                "feature-not-available" => GetDrainResponseVariant1DisabledReason.FeatureNotAvailable,
                _ => null,
            };
        }
    }
}