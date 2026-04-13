
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerTeamTeamRole
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
    public static class UserEventPayloadVariant116NewOwnerTeamTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerTeamTeamRole value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerTeamTeamRole.Billing => "BILLING",
                UserEventPayloadVariant116NewOwnerTeamTeamRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant116NewOwnerTeamTeamRole.Developer => "DEVELOPER",
                UserEventPayloadVariant116NewOwnerTeamTeamRole.Member => "MEMBER",
                UserEventPayloadVariant116NewOwnerTeamTeamRole.Owner => "OWNER",
                UserEventPayloadVariant116NewOwnerTeamTeamRole.Security => "SECURITY",
                UserEventPayloadVariant116NewOwnerTeamTeamRole.Viewer => "VIEWER",
                UserEventPayloadVariant116NewOwnerTeamTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerTeamTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant116NewOwnerTeamTeamRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant116NewOwnerTeamTeamRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant116NewOwnerTeamTeamRole.Developer,
                "MEMBER" => UserEventPayloadVariant116NewOwnerTeamTeamRole.Member,
                "OWNER" => UserEventPayloadVariant116NewOwnerTeamTeamRole.Owner,
                "SECURITY" => UserEventPayloadVariant116NewOwnerTeamTeamRole.Security,
                "VIEWER" => UserEventPayloadVariant116NewOwnerTeamTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant116NewOwnerTeamTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}