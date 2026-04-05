
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationResponseVariant3DisabledReason
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
    public static class GetConfigurationResponseVariant3DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant3DisabledReason value)
        {
            return value switch
            {
                GetConfigurationResponseVariant3DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                GetConfigurationResponseVariant3DisabledReason.DisabledByAdmin => "disabled-by-admin",
                GetConfigurationResponseVariant3DisabledReason.DisabledByOwner => "disabled-by-owner",
                GetConfigurationResponseVariant3DisabledReason.FeatureNotAvailable => "feature-not-available",
                GetConfigurationResponseVariant3DisabledReason.OriginalOwnerLeftTheTeam => "original-owner-left-the-team",
                GetConfigurationResponseVariant3DisabledReason.OriginalOwnerRoleDowngraded => "original-owner-role-downgraded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant3DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => GetConfigurationResponseVariant3DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => GetConfigurationResponseVariant3DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => GetConfigurationResponseVariant3DisabledReason.DisabledByOwner,
                "feature-not-available" => GetConfigurationResponseVariant3DisabledReason.FeatureNotAvailable,
                "original-owner-left-the-team" => GetConfigurationResponseVariant3DisabledReason.OriginalOwnerLeftTheTeam,
                "original-owner-role-downgraded" => GetConfigurationResponseVariant3DisabledReason.OriginalOwnerRoleDowngraded,
                _ => null,
            };
        }
    }
}