
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchTeamRequestSamlRolesEnum
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
    public static class PatchTeamRequestSamlRolesEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestSamlRolesEnum value)
        {
            return value switch
            {
                PatchTeamRequestSamlRolesEnum.Billing => "BILLING",
                PatchTeamRequestSamlRolesEnum.Contributor => "CONTRIBUTOR",
                PatchTeamRequestSamlRolesEnum.Developer => "DEVELOPER",
                PatchTeamRequestSamlRolesEnum.Member => "MEMBER",
                PatchTeamRequestSamlRolesEnum.Owner => "OWNER",
                PatchTeamRequestSamlRolesEnum.Security => "SECURITY",
                PatchTeamRequestSamlRolesEnum.Viewer => "VIEWER",
                PatchTeamRequestSamlRolesEnum.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestSamlRolesEnum? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => PatchTeamRequestSamlRolesEnum.Billing,
                "CONTRIBUTOR" => PatchTeamRequestSamlRolesEnum.Contributor,
                "DEVELOPER" => PatchTeamRequestSamlRolesEnum.Developer,
                "MEMBER" => PatchTeamRequestSamlRolesEnum.Member,
                "OWNER" => PatchTeamRequestSamlRolesEnum.Owner,
                "SECURITY" => PatchTeamRequestSamlRolesEnum.Security,
                "VIEWER" => PatchTeamRequestSamlRolesEnum.Viewer,
                "VIEWER_FOR_PLUS" => PatchTeamRequestSamlRolesEnum.ViewerForPlus,
                _ => null,
            };
        }
    }
}