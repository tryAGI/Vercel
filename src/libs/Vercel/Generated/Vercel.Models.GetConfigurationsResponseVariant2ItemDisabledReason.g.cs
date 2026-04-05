
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationsResponseVariant2ItemDisabledReason
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
    public static class GetConfigurationsResponseVariant2ItemDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsResponseVariant2ItemDisabledReason value)
        {
            return value switch
            {
                GetConfigurationsResponseVariant2ItemDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                GetConfigurationsResponseVariant2ItemDisabledReason.DisabledByAdmin => "disabled-by-admin",
                GetConfigurationsResponseVariant2ItemDisabledReason.DisabledByOwner => "disabled-by-owner",
                GetConfigurationsResponseVariant2ItemDisabledReason.FeatureNotAvailable => "feature-not-available",
                GetConfigurationsResponseVariant2ItemDisabledReason.OriginalOwnerLeftTheTeam => "original-owner-left-the-team",
                GetConfigurationsResponseVariant2ItemDisabledReason.OriginalOwnerRoleDowngraded => "original-owner-role-downgraded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsResponseVariant2ItemDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => GetConfigurationsResponseVariant2ItemDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => GetConfigurationsResponseVariant2ItemDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => GetConfigurationsResponseVariant2ItemDisabledReason.DisabledByOwner,
                "feature-not-available" => GetConfigurationsResponseVariant2ItemDisabledReason.FeatureNotAvailable,
                "original-owner-left-the-team" => GetConfigurationsResponseVariant2ItemDisabledReason.OriginalOwnerLeftTheTeam,
                "original-owner-role-downgraded" => GetConfigurationsResponseVariant2ItemDisabledReason.OriginalOwnerRoleDowngraded,
                _ => null,
            };
        }
    }
}