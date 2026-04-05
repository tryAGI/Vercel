
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2DisabledReason
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
    public static class CreateDrainResponseVariant2DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2DisabledReason value)
        {
            return value switch
            {
                CreateDrainResponseVariant2DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                CreateDrainResponseVariant2DisabledReason.DisabledByAdmin => "disabled-by-admin",
                CreateDrainResponseVariant2DisabledReason.DisabledByOwner => "disabled-by-owner",
                CreateDrainResponseVariant2DisabledReason.FeatureNotAvailable => "feature-not-available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => CreateDrainResponseVariant2DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => CreateDrainResponseVariant2DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => CreateDrainResponseVariant2DisabledReason.DisabledByOwner,
                "feature-not-available" => CreateDrainResponseVariant2DisabledReason.FeatureNotAvailable,
                _ => null,
            };
        }
    }
}