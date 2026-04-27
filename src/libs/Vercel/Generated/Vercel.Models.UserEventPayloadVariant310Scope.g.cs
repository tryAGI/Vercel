
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Scope of the token: - `'user'`: full-account token (not tied to any team). - `'team'`: scoped to a single team. - `'project'`: scoped to a single project within a team.
    /// </summary>
    public enum UserEventPayloadVariant310Scope
    {
        /// <summary>
        /// - `'user'`: full-account token (not tied to any team). - `'team'`: scoped to a single team. - `'project'`: scoped to a single project within a team.
        /// </summary>
        Project,
        /// <summary>
        /// - `'user'`: full-account token (not tied to any team). - `'team'`: scoped to a single team. - `'project'`: scoped to a single project within a team.
        /// </summary>
        Team,
        /// <summary>
        /// - `'user'`: full-account token (not tied to any team). - `'team'`: scoped to a single team. - `'project'`: scoped to a single project within a team.
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant310ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant310Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant310Scope.Project => "project",
                UserEventPayloadVariant310Scope.Team => "team",
                UserEventPayloadVariant310Scope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant310Scope? ToEnum(string value)
        {
            return value switch
            {
                "project" => UserEventPayloadVariant310Scope.Project,
                "team" => UserEventPayloadVariant310Scope.Team,
                "user" => UserEventPayloadVariant310Scope.User,
                _ => null,
            };
        }
    }
}