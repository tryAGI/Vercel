
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerTeamTeamRole
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
    public static class UserEventPayloadVariant114NewOwnerTeamTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerTeamTeamRole value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerTeamTeamRole.Billing => "BILLING",
                UserEventPayloadVariant114NewOwnerTeamTeamRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant114NewOwnerTeamTeamRole.Developer => "DEVELOPER",
                UserEventPayloadVariant114NewOwnerTeamTeamRole.Member => "MEMBER",
                UserEventPayloadVariant114NewOwnerTeamTeamRole.Owner => "OWNER",
                UserEventPayloadVariant114NewOwnerTeamTeamRole.Security => "SECURITY",
                UserEventPayloadVariant114NewOwnerTeamTeamRole.Viewer => "VIEWER",
                UserEventPayloadVariant114NewOwnerTeamTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerTeamTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant114NewOwnerTeamTeamRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant114NewOwnerTeamTeamRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant114NewOwnerTeamTeamRole.Developer,
                "MEMBER" => UserEventPayloadVariant114NewOwnerTeamTeamRole.Member,
                "OWNER" => UserEventPayloadVariant114NewOwnerTeamTeamRole.Owner,
                "SECURITY" => UserEventPayloadVariant114NewOwnerTeamTeamRole.Security,
                "VIEWER" => UserEventPayloadVariant114NewOwnerTeamTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant114NewOwnerTeamTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}