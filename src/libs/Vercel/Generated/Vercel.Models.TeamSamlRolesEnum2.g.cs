
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamSamlRolesEnum2
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
    public static class TeamSamlRolesEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamSamlRolesEnum2 value)
        {
            return value switch
            {
                TeamSamlRolesEnum2.Billing => "BILLING",
                TeamSamlRolesEnum2.Contributor => "CONTRIBUTOR",
                TeamSamlRolesEnum2.Developer => "DEVELOPER",
                TeamSamlRolesEnum2.Member => "MEMBER",
                TeamSamlRolesEnum2.Owner => "OWNER",
                TeamSamlRolesEnum2.Security => "SECURITY",
                TeamSamlRolesEnum2.Viewer => "VIEWER",
                TeamSamlRolesEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamSamlRolesEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => TeamSamlRolesEnum2.Billing,
                "CONTRIBUTOR" => TeamSamlRolesEnum2.Contributor,
                "DEVELOPER" => TeamSamlRolesEnum2.Developer,
                "MEMBER" => TeamSamlRolesEnum2.Member,
                "OWNER" => TeamSamlRolesEnum2.Owner,
                "SECURITY" => TeamSamlRolesEnum2.Security,
                "VIEWER" => TeamSamlRolesEnum2.Viewer,
                "VIEWER_FOR_PLUS" => TeamSamlRolesEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}