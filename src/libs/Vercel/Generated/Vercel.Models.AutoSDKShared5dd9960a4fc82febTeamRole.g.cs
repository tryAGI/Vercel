
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5dd9960a4fc82febTeamRole
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
    public static class AutoSDKShared5dd9960a4fc82febTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5dd9960a4fc82febTeamRole value)
        {
            return value switch
            {
                AutoSDKShared5dd9960a4fc82febTeamRole.Billing => "BILLING",
                AutoSDKShared5dd9960a4fc82febTeamRole.Contributor => "CONTRIBUTOR",
                AutoSDKShared5dd9960a4fc82febTeamRole.Developer => "DEVELOPER",
                AutoSDKShared5dd9960a4fc82febTeamRole.Member => "MEMBER",
                AutoSDKShared5dd9960a4fc82febTeamRole.Owner => "OWNER",
                AutoSDKShared5dd9960a4fc82febTeamRole.Security => "SECURITY",
                AutoSDKShared5dd9960a4fc82febTeamRole.Viewer => "VIEWER",
                AutoSDKShared5dd9960a4fc82febTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5dd9960a4fc82febTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => AutoSDKShared5dd9960a4fc82febTeamRole.Billing,
                "CONTRIBUTOR" => AutoSDKShared5dd9960a4fc82febTeamRole.Contributor,
                "DEVELOPER" => AutoSDKShared5dd9960a4fc82febTeamRole.Developer,
                "MEMBER" => AutoSDKShared5dd9960a4fc82febTeamRole.Member,
                "OWNER" => AutoSDKShared5dd9960a4fc82febTeamRole.Owner,
                "SECURITY" => AutoSDKShared5dd9960a4fc82febTeamRole.Security,
                "VIEWER" => AutoSDKShared5dd9960a4fc82febTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => AutoSDKShared5dd9960a4fc82febTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}