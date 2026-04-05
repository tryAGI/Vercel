
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant1DisabledReason
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
    public static class CreateDrainResponseVariant1DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant1DisabledReason value)
        {
            return value switch
            {
                CreateDrainResponseVariant1DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                CreateDrainResponseVariant1DisabledReason.DisabledByAdmin => "disabled-by-admin",
                CreateDrainResponseVariant1DisabledReason.DisabledByOwner => "disabled-by-owner",
                CreateDrainResponseVariant1DisabledReason.FeatureNotAvailable => "feature-not-available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant1DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => CreateDrainResponseVariant1DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => CreateDrainResponseVariant1DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => CreateDrainResponseVariant1DisabledReason.DisabledByOwner,
                "feature-not-available" => CreateDrainResponseVariant1DisabledReason.FeatureNotAvailable,
                _ => null,
            };
        }
    }
}