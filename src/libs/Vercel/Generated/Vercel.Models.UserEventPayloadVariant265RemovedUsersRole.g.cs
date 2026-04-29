
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant265RemovedUsersRole
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
    public static class UserEventPayloadVariant265RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant265RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant265RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant265RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant265RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant265RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant265RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant265RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant265RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant265RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant265RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant265RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant265RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant265RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant265RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant265RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant265RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant265RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant265RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}