
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationTeamListItemSsoMode
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
    public static class OrganizationTeamListItemSsoModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationTeamListItemSsoMode value)
        {
            return value switch
            {
                OrganizationTeamListItemSsoMode.Organization => "organization",
                OrganizationTeamListItemSsoMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationTeamListItemSsoMode? ToEnum(string value)
        {
            return value switch
            {
                "organization" => OrganizationTeamListItemSsoMode.Organization,
                "team" => OrganizationTeamListItemSsoMode.Team,
                _ => null,
            };
        }
    }
}