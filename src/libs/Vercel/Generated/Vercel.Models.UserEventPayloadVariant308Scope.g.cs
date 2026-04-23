
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Scope of the token: - `'user'`: full-account token (not tied to any team). - `'team'`: scoped to a single team. - `'project'`: scoped to a single project within a team.
    /// </summary>
    public enum UserEventPayloadVariant308Scope
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
    public static class UserEventPayloadVariant308ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant308Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant308Scope.Project => "project",
                UserEventPayloadVariant308Scope.Team => "team",
                UserEventPayloadVariant308Scope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant308Scope? ToEnum(string value)
        {
            return value switch
            {
                "project" => UserEventPayloadVariant308Scope.Project,
                "team" => UserEventPayloadVariant308Scope.Team,
                "user" => UserEventPayloadVariant308Scope.User,
                _ => null,
            };
        }
    }
}