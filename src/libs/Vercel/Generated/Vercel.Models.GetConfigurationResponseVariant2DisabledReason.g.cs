
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationResponseVariant2DisabledReason
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
        /// <summary>
        /// 
        /// </summary>
        OriginalOwnerLeftTheTeam,
        /// <summary>
        /// 
        /// </summary>
        OriginalOwnerRoleDowngraded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationResponseVariant2DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant2DisabledReason value)
        {
            return value switch
            {
                GetConfigurationResponseVariant2DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                GetConfigurationResponseVariant2DisabledReason.DisabledByAdmin => "disabled-by-admin",
                GetConfigurationResponseVariant2DisabledReason.DisabledByOwner => "disabled-by-owner",
                GetConfigurationResponseVariant2DisabledReason.FeatureNotAvailable => "feature-not-available",
                GetConfigurationResponseVariant2DisabledReason.OriginalOwnerLeftTheTeam => "original-owner-left-the-team",
                GetConfigurationResponseVariant2DisabledReason.OriginalOwnerRoleDowngraded => "original-owner-role-downgraded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant2DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => GetConfigurationResponseVariant2DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => GetConfigurationResponseVariant2DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => GetConfigurationResponseVariant2DisabledReason.DisabledByOwner,
                "feature-not-available" => GetConfigurationResponseVariant2DisabledReason.FeatureNotAvailable,
                "original-owner-left-the-team" => GetConfigurationResponseVariant2DisabledReason.OriginalOwnerLeftTheTeam,
                "original-owner-role-downgraded" => GetConfigurationResponseVariant2DisabledReason.OriginalOwnerRoleDowngraded,
                _ => null,
            };
        }
    }
}