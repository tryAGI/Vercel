
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamSamlRolesEnum3
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
    public static class TeamSamlRolesEnum3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamSamlRolesEnum3 value)
        {
            return value switch
            {
                TeamSamlRolesEnum3.Billing => "BILLING",
                TeamSamlRolesEnum3.Contributor => "CONTRIBUTOR",
                TeamSamlRolesEnum3.Developer => "DEVELOPER",
                TeamSamlRolesEnum3.Member => "MEMBER",
                TeamSamlRolesEnum3.Owner => "OWNER",
                TeamSamlRolesEnum3.Security => "SECURITY",
                TeamSamlRolesEnum3.Viewer => "VIEWER",
                TeamSamlRolesEnum3.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamSamlRolesEnum3? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => TeamSamlRolesEnum3.Billing,
                "CONTRIBUTOR" => TeamSamlRolesEnum3.Contributor,
                "DEVELOPER" => TeamSamlRolesEnum3.Developer,
                "MEMBER" => TeamSamlRolesEnum3.Member,
                "OWNER" => TeamSamlRolesEnum3.Owner,
                "SECURITY" => TeamSamlRolesEnum3.Security,
                "VIEWER" => TeamSamlRolesEnum3.Viewer,
                "VIEWER_FOR_PLUS" => TeamSamlRolesEnum3.ViewerForPlus,
                _ => null,
            };
        }
    }
}