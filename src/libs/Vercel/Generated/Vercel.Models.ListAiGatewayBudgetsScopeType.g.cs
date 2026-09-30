
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Restrict the list to a single budget scope.
    /// </summary>
    public enum ListAiGatewayBudgetsScopeType
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
    public static class ListAiGatewayBudgetsScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAiGatewayBudgetsScopeType value)
        {
            return value switch
            {
                ListAiGatewayBudgetsScopeType.ApiKey => "api-key",
                ListAiGatewayBudgetsScopeType.Project => "project",
                ListAiGatewayBudgetsScopeType.Team => "team",
                ListAiGatewayBudgetsScopeType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAiGatewayBudgetsScopeType? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => ListAiGatewayBudgetsScopeType.ApiKey,
                "project" => ListAiGatewayBudgetsScopeType.Project,
                "team" => ListAiGatewayBudgetsScopeType.Team,
                "user" => ListAiGatewayBudgetsScopeType.User,
                _ => null,
            };
        }
    }
}