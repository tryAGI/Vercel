
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The child team's billing profile within the organization. Optional: links created before this attribute existed have no stored value.
    /// </summary>
    public enum OrganizationTeamBillingPlan
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
    public static class OrganizationTeamBillingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationTeamBillingPlan value)
        {
            return value switch
            {
                OrganizationTeamBillingPlan.Enterprise => "enterprise",
                OrganizationTeamBillingPlan.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationTeamBillingPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => OrganizationTeamBillingPlan.Enterprise,
                "platform" => OrganizationTeamBillingPlan.Platform,
                _ => null,
            };
        }
    }
}