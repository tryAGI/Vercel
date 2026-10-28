
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the organization's Directory Sync manages the team's memberships.
    /// </summary>
    public enum OrganizationTeamListItemDsyncMode
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationTeamListItemDsyncModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationTeamListItemDsyncMode value)
        {
            return value switch
            {
                OrganizationTeamListItemDsyncMode.Organization => "organization",
                OrganizationTeamListItemDsyncMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationTeamListItemDsyncMode? ToEnum(string value)
        {
            return value switch
            {
                "organization" => OrganizationTeamListItemDsyncMode.Organization,
                "team" => OrganizationTeamListItemDsyncMode.Team,
                _ => null,
            };
        }
    }
}