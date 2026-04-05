
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2DisabledReason
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
    public static class UpdateDrainResponseVariant2DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2DisabledReason value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                UpdateDrainResponseVariant2DisabledReason.DisabledByAdmin => "disabled-by-admin",
                UpdateDrainResponseVariant2DisabledReason.DisabledByOwner => "disabled-by-owner",
                UpdateDrainResponseVariant2DisabledReason.FeatureNotAvailable => "feature-not-available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => UpdateDrainResponseVariant2DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => UpdateDrainResponseVariant2DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => UpdateDrainResponseVariant2DisabledReason.DisabledByOwner,
                "feature-not-available" => UpdateDrainResponseVariant2DisabledReason.FeatureNotAvailable,
                _ => null,
            };
        }
    }
}