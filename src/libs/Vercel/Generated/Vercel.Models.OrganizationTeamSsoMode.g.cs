
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationTeamSsoMode
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
    public static class OrganizationTeamSsoModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationTeamSsoMode value)
        {
            return value switch
            {
                OrganizationTeamSsoMode.Organization => "organization",
                OrganizationTeamSsoMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationTeamSsoMode? ToEnum(string value)
        {
            return value switch
            {
                "organization" => OrganizationTeamSsoMode.Organization,
                "team" => OrganizationTeamSsoMode.Team,
                _ => null,
            };
        }
    }
}