
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Role of this user in the project.<br/>
    /// Example: ADMIN
    /// </summary>
    public enum GetProjectMembersResponseVariant2MemberComputedProjectRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        ProjectDeveloper,
        /// <summary>
        /// 
        /// </summary>
        ProjectGuest,
        /// <summary>
        /// 
        /// </summary>
        ProjectViewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectMembersResponseVariant2MemberComputedProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectMembersResponseVariant2MemberComputedProjectRole value)
        {
            return value switch
            {
                GetProjectMembersResponseVariant2MemberComputedProjectRole.Admin => "ADMIN",
                GetProjectMembersResponseVariant2MemberComputedProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                GetProjectMembersResponseVariant2MemberComputedProjectRole.ProjectGuest => "PROJECT_GUEST",
                GetProjectMembersResponseVariant2MemberComputedProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectMembersResponseVariant2MemberComputedProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => GetProjectMembersResponseVariant2MemberComputedProjectRole.Admin,
                "PROJECT_DEVELOPER" => GetProjectMembersResponseVariant2MemberComputedProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => GetProjectMembersResponseVariant2MemberComputedProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => GetProjectMembersResponseVariant2MemberComputedProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}