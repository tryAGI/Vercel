
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AddOrganizationTeamRequestBillingPlan
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddOrganizationTeamRequestBillingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddOrganizationTeamRequestBillingPlan value)
        {
            return value switch
            {
                AddOrganizationTeamRequestBillingPlan.Enterprise => "enterprise",
                AddOrganizationTeamRequestBillingPlan.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddOrganizationTeamRequestBillingPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => AddOrganizationTeamRequestBillingPlan.Enterprise,
                "platform" => AddOrganizationTeamRequestBillingPlan.Platform,
                _ => null,
            };
        }
    }
}