
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Scope of the token: - `'user'`: full-account token (not tied to any team). - `'team'`: scoped to a single team. - `'project'`: scoped to a single project within a team.
    /// </summary>
    public enum UserEventPayloadVariant320Scope
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
    public static class UserEventPayloadVariant320ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant320Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant320Scope.Project => "project",
                UserEventPayloadVariant320Scope.Team => "team",
                UserEventPayloadVariant320Scope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant320Scope? ToEnum(string value)
        {
            return value switch
            {
                "project" => UserEventPayloadVariant320Scope.Project,
                "team" => UserEventPayloadVariant320Scope.Team,
                "user" => UserEventPayloadVariant320Scope.User,
                _ => null,
            };
        }
    }
}