
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The budget scope to archive.
    /// </summary>
    public enum ArchiveAiGatewayBudgetScopeType
    {
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        Team,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArchiveAiGatewayBudgetScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArchiveAiGatewayBudgetScopeType value)
        {
            return value switch
            {
                ArchiveAiGatewayBudgetScopeType.Project => "project",
                ArchiveAiGatewayBudgetScopeType.Team => "team",
                ArchiveAiGatewayBudgetScopeType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArchiveAiGatewayBudgetScopeType? ToEnum(string value)
        {
            return value switch
            {
                "project" => ArchiveAiGatewayBudgetScopeType.Project,
                "team" => ArchiveAiGatewayBudgetScopeType.Team,
                "user" => ArchiveAiGatewayBudgetScopeType.User,
                _ => null,
            };
        }
    }
}