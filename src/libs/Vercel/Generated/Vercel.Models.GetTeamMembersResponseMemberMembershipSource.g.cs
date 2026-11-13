
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The source controlling this member's team access and roles. Individual permissions may have a different source. This does not replace authorization checks.
    /// </summary>
    public enum GetTeamMembersResponseMemberMembershipSource
    {
        /// <summary>
        ///
        /// </summary>
        Direct,
        /// <summary>
        ///
        /// </summary>
        OrganizationDirectory,
        /// <summary>
        ///
        /// </summary>
        TeamDirectory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTeamMembersResponseMemberMembershipSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTeamMembersResponseMemberMembershipSource value)
        {
            return value switch
            {
                GetTeamMembersResponseMemberMembershipSource.Direct => "direct",
                GetTeamMembersResponseMemberMembershipSource.OrganizationDirectory => "organization-directory",
                GetTeamMembersResponseMemberMembershipSource.TeamDirectory => "team-directory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTeamMembersResponseMemberMembershipSource? ToEnum(string value)
        {
            return value switch
            {
                "direct" => GetTeamMembersResponseMemberMembershipSource.Direct,
                "organization-directory" => GetTeamMembersResponseMemberMembershipSource.OrganizationDirectory,
                "team-directory" => GetTeamMembersResponseMemberMembershipSource.TeamDirectory,
                _ => null,
            };
        }
    }
}