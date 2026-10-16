
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing profile of the organization link: how this team settles within the organization. This is not the team's billing.plan or planIteration. Links with `enterprise` billing participate in organization-level billing and usage rollups. This field is optional for legacy links that have no stored profile.
    /// </summary>
    public enum OrganizationTeamListItemBillingPlan
    {
        /// <summary>
        /// how this team settles within the organization. This is not the team's billing.plan or planIteration. Links with `enterprise` billing participate in organization-level billing and usage rollups. This field is optional for legacy links that have no stored profile.
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
    public static class OrganizationTeamListItemBillingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationTeamListItemBillingPlan value)
        {
            return value switch
            {
                OrganizationTeamListItemBillingPlan.Enterprise => "enterprise",
                OrganizationTeamListItemBillingPlan.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationTeamListItemBillingPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => OrganizationTeamListItemBillingPlan.Enterprise,
                "platform" => OrganizationTeamListItemBillingPlan.Platform,
                _ => null,
            };
        }
    }
}