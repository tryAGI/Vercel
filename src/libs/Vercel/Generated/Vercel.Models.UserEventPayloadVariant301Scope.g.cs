
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Scope of the token: - `'user'`: full-account token (not tied to any team). - `'team'`: scoped to a single team. - `'project'`: scoped to a single project within a team.
    /// </summary>
    public enum UserEventPayloadVariant301Scope
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
    public static class UserEventPayloadVariant301ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant301Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant301Scope.Project => "project",
                UserEventPayloadVariant301Scope.Team => "team",
                UserEventPayloadVariant301Scope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant301Scope? ToEnum(string value)
        {
            return value switch
            {
                "project" => UserEventPayloadVariant301Scope.Project,
                "team" => UserEventPayloadVariant301Scope.Team,
                "user" => UserEventPayloadVariant301Scope.User,
                _ => null,
            };
        }
    }
}