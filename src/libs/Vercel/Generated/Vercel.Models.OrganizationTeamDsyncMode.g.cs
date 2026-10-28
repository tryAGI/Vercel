
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the organization's Directory Sync manages the team's memberships.
    /// </summary>
    public enum OrganizationTeamDsyncMode
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
    public static class OrganizationTeamDsyncModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationTeamDsyncMode value)
        {
            return value switch
            {
                OrganizationTeamDsyncMode.Organization => "organization",
                OrganizationTeamDsyncMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationTeamDsyncMode? ToEnum(string value)
        {
            return value switch
            {
                "organization" => OrganizationTeamDsyncMode.Organization,
                "team" => OrganizationTeamDsyncMode.Team,
                _ => null,
            };
        }
    }
}