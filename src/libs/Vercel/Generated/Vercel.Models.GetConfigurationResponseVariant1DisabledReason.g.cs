
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationResponseVariant1DisabledReason
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
    public static class GetConfigurationResponseVariant1DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant1DisabledReason value)
        {
            return value switch
            {
                GetConfigurationResponseVariant1DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                GetConfigurationResponseVariant1DisabledReason.DisabledByAdmin => "disabled-by-admin",
                GetConfigurationResponseVariant1DisabledReason.DisabledByOwner => "disabled-by-owner",
                GetConfigurationResponseVariant1DisabledReason.FeatureNotAvailable => "feature-not-available",
                GetConfigurationResponseVariant1DisabledReason.OriginalOwnerLeftTheTeam => "original-owner-left-the-team",
                GetConfigurationResponseVariant1DisabledReason.OriginalOwnerRoleDowngraded => "original-owner-role-downgraded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant1DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => GetConfigurationResponseVariant1DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => GetConfigurationResponseVariant1DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => GetConfigurationResponseVariant1DisabledReason.DisabledByOwner,
                "feature-not-available" => GetConfigurationResponseVariant1DisabledReason.FeatureNotAvailable,
                "original-owner-left-the-team" => GetConfigurationResponseVariant1DisabledReason.OriginalOwnerLeftTheTeam,
                "original-owner-role-downgraded" => GetConfigurationResponseVariant1DisabledReason.OriginalOwnerRoleDowngraded,
                _ => null,
            };
        }
    }
}