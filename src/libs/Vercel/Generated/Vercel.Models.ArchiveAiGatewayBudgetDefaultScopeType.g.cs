
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The budget default scope to delete.
    /// </summary>
    public enum ArchiveAiGatewayBudgetDefaultScopeType
    {
        /// <summary>
        ///
        /// </summary>
        ApiKey,
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
    public static class ArchiveAiGatewayBudgetDefaultScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArchiveAiGatewayBudgetDefaultScopeType value)
        {
            return value switch
            {
                ArchiveAiGatewayBudgetDefaultScopeType.ApiKey => "api-key",
                ArchiveAiGatewayBudgetDefaultScopeType.Project => "project",
                ArchiveAiGatewayBudgetDefaultScopeType.Team => "team",
                ArchiveAiGatewayBudgetDefaultScopeType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArchiveAiGatewayBudgetDefaultScopeType? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => ArchiveAiGatewayBudgetDefaultScopeType.ApiKey,
                "project" => ArchiveAiGatewayBudgetDefaultScopeType.Project,
                "team" => ArchiveAiGatewayBudgetDefaultScopeType.Team,
                "user" => ArchiveAiGatewayBudgetDefaultScopeType.User,
                _ => null,
            };
        }
    }
}