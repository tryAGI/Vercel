
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant1DisabledReason
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
    public static class UpdateDrainResponseVariant1DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant1DisabledReason value)
        {
            return value switch
            {
                UpdateDrainResponseVariant1DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                UpdateDrainResponseVariant1DisabledReason.DisabledByAdmin => "disabled-by-admin",
                UpdateDrainResponseVariant1DisabledReason.DisabledByOwner => "disabled-by-owner",
                UpdateDrainResponseVariant1DisabledReason.FeatureNotAvailable => "feature-not-available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant1DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => UpdateDrainResponseVariant1DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => UpdateDrainResponseVariant1DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => UpdateDrainResponseVariant1DisabledReason.DisabledByOwner,
                "feature-not-available" => UpdateDrainResponseVariant1DisabledReason.FeatureNotAvailable,
                _ => null,
            };
        }
    }
}