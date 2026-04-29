
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerTeamTeamRole
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
    public static class UserEventPayloadVariant122NewOwnerTeamTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerTeamTeamRole value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerTeamTeamRole.Billing => "BILLING",
                UserEventPayloadVariant122NewOwnerTeamTeamRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant122NewOwnerTeamTeamRole.Developer => "DEVELOPER",
                UserEventPayloadVariant122NewOwnerTeamTeamRole.Member => "MEMBER",
                UserEventPayloadVariant122NewOwnerTeamTeamRole.Owner => "OWNER",
                UserEventPayloadVariant122NewOwnerTeamTeamRole.Security => "SECURITY",
                UserEventPayloadVariant122NewOwnerTeamTeamRole.Viewer => "VIEWER",
                UserEventPayloadVariant122NewOwnerTeamTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerTeamTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant122NewOwnerTeamTeamRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant122NewOwnerTeamTeamRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant122NewOwnerTeamTeamRole.Developer,
                "MEMBER" => UserEventPayloadVariant122NewOwnerTeamTeamRole.Member,
                "OWNER" => UserEventPayloadVariant122NewOwnerTeamTeamRole.Owner,
                "SECURITY" => UserEventPayloadVariant122NewOwnerTeamTeamRole.Security,
                "VIEWER" => UserEventPayloadVariant122NewOwnerTeamTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant122NewOwnerTeamTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}