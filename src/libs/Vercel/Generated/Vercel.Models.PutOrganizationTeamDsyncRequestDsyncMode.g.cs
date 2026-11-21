
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the Organization's Directory Sync or the team's own directory governs the team's memberships.
    /// </summary>
    public enum PutOrganizationTeamDsyncRequestDsyncMode
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
    public static class PutOrganizationTeamDsyncRequestDsyncModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationTeamDsyncRequestDsyncMode value)
        {
            return value switch
            {
                PutOrganizationTeamDsyncRequestDsyncMode.Organization => "organization",
                PutOrganizationTeamDsyncRequestDsyncMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationTeamDsyncRequestDsyncMode? ToEnum(string value)
        {
            return value switch
            {
                "organization" => PutOrganizationTeamDsyncRequestDsyncMode.Organization,
                "team" => PutOrganizationTeamDsyncRequestDsyncMode.Team,
                _ => null,
            };
        }
    }
}