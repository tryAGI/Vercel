
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared362c8e760cc311d9TeamRole
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
    public static class AutoSDKShared362c8e760cc311d9TeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared362c8e760cc311d9TeamRole value)
        {
            return value switch
            {
                AutoSDKShared362c8e760cc311d9TeamRole.Billing => "BILLING",
                AutoSDKShared362c8e760cc311d9TeamRole.Contributor => "CONTRIBUTOR",
                AutoSDKShared362c8e760cc311d9TeamRole.Developer => "DEVELOPER",
                AutoSDKShared362c8e760cc311d9TeamRole.Member => "MEMBER",
                AutoSDKShared362c8e760cc311d9TeamRole.Owner => "OWNER",
                AutoSDKShared362c8e760cc311d9TeamRole.Security => "SECURITY",
                AutoSDKShared362c8e760cc311d9TeamRole.Viewer => "VIEWER",
                AutoSDKShared362c8e760cc311d9TeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared362c8e760cc311d9TeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => AutoSDKShared362c8e760cc311d9TeamRole.Billing,
                "CONTRIBUTOR" => AutoSDKShared362c8e760cc311d9TeamRole.Contributor,
                "DEVELOPER" => AutoSDKShared362c8e760cc311d9TeamRole.Developer,
                "MEMBER" => AutoSDKShared362c8e760cc311d9TeamRole.Member,
                "OWNER" => AutoSDKShared362c8e760cc311d9TeamRole.Owner,
                "SECURITY" => AutoSDKShared362c8e760cc311d9TeamRole.Security,
                "VIEWER" => AutoSDKShared362c8e760cc311d9TeamRole.Viewer,
                "VIEWER_FOR_PLUS" => AutoSDKShared362c8e760cc311d9TeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}