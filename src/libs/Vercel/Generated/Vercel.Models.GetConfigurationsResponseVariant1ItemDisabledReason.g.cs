
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationsResponseVariant1ItemDisabledReason
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
    public static class GetConfigurationsResponseVariant1ItemDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsResponseVariant1ItemDisabledReason value)
        {
            return value switch
            {
                GetConfigurationsResponseVariant1ItemDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                GetConfigurationsResponseVariant1ItemDisabledReason.DisabledByAdmin => "disabled-by-admin",
                GetConfigurationsResponseVariant1ItemDisabledReason.DisabledByOwner => "disabled-by-owner",
                GetConfigurationsResponseVariant1ItemDisabledReason.FeatureNotAvailable => "feature-not-available",
                GetConfigurationsResponseVariant1ItemDisabledReason.OriginalOwnerLeftTheTeam => "original-owner-left-the-team",
                GetConfigurationsResponseVariant1ItemDisabledReason.OriginalOwnerRoleDowngraded => "original-owner-role-downgraded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsResponseVariant1ItemDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => GetConfigurationsResponseVariant1ItemDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => GetConfigurationsResponseVariant1ItemDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => GetConfigurationsResponseVariant1ItemDisabledReason.DisabledByOwner,
                "feature-not-available" => GetConfigurationsResponseVariant1ItemDisabledReason.FeatureNotAvailable,
                "original-owner-left-the-team" => GetConfigurationsResponseVariant1ItemDisabledReason.OriginalOwnerLeftTheTeam,
                "original-owner-role-downgraded" => GetConfigurationsResponseVariant1ItemDisabledReason.OriginalOwnerRoleDowngraded,
                _ => null,
            };
        }
    }
}