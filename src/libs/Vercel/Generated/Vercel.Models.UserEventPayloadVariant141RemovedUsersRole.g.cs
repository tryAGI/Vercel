
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant141RemovedUsersRole
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
    public static class UserEventPayloadVariant141RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant141RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant141RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant141RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant141RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant141RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant141RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant141RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant141RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant141RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant141RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant141RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant141RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant141RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant141RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant141RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant141RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant141RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant141RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}