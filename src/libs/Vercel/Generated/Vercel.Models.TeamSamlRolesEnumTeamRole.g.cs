
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamSamlRolesEnumTeamRole
    {
        /// <summary>
        ///
        /// </summary>
        Billing,
        /// <summary>
        ///
        /// </summary>
        Contributor,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        Member,
        /// <summary>
        ///
        /// </summary>
        Owner,
        /// <summary>
        ///
        /// </summary>
        Security,
        /// <summary>
        ///
        /// </summary>
        Viewer,
        /// <summary>
        ///
        /// </summary>
        ViewerForPlus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamSamlRolesEnumTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamSamlRolesEnumTeamRole value)
        {
            return value switch
            {
                TeamSamlRolesEnumTeamRole.Billing => "BILLING",
                TeamSamlRolesEnumTeamRole.Contributor => "CONTRIBUTOR",
                TeamSamlRolesEnumTeamRole.Developer => "DEVELOPER",
                TeamSamlRolesEnumTeamRole.Member => "MEMBER",
                TeamSamlRolesEnumTeamRole.Owner => "OWNER",
                TeamSamlRolesEnumTeamRole.Security => "SECURITY",
                TeamSamlRolesEnumTeamRole.Viewer => "VIEWER",
                TeamSamlRolesEnumTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamSamlRolesEnumTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => TeamSamlRolesEnumTeamRole.Billing,
                "CONTRIBUTOR" => TeamSamlRolesEnumTeamRole.Contributor,
                "DEVELOPER" => TeamSamlRolesEnumTeamRole.Developer,
                "MEMBER" => TeamSamlRolesEnumTeamRole.Member,
                "OWNER" => TeamSamlRolesEnumTeamRole.Owner,
                "SECURITY" => TeamSamlRolesEnumTeamRole.Security,
                "VIEWER" => TeamSamlRolesEnumTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => TeamSamlRolesEnumTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}