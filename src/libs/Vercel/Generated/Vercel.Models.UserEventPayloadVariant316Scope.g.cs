
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Scope of the token: - `'user'`: full-account token (not tied to any team). - `'team'`: scoped to a single team. - `'project'`: scoped to a single project within a team.
    /// </summary>
    public enum UserEventPayloadVariant316Scope
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
    public static class UserEventPayloadVariant316ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant316Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant316Scope.Project => "project",
                UserEventPayloadVariant316Scope.Team => "team",
                UserEventPayloadVariant316Scope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant316Scope? ToEnum(string value)
        {
            return value switch
            {
                "project" => UserEventPayloadVariant316Scope.Project,
                "team" => UserEventPayloadVariant316Scope.Team,
                "user" => UserEventPayloadVariant316Scope.User,
                _ => null,
            };
        }
    }
}