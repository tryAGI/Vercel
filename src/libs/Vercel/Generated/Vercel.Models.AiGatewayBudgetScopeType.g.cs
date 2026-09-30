
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AiGatewayBudgetScopeType
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
    public static class AiGatewayBudgetScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayBudgetScopeType value)
        {
            return value switch
            {
                AiGatewayBudgetScopeType.ApiKey => "api-key",
                AiGatewayBudgetScopeType.Project => "project",
                AiGatewayBudgetScopeType.Team => "team",
                AiGatewayBudgetScopeType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayBudgetScopeType? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => AiGatewayBudgetScopeType.ApiKey,
                "project" => AiGatewayBudgetScopeType.Project,
                "team" => AiGatewayBudgetScopeType.Team,
                "user" => AiGatewayBudgetScopeType.User,
                _ => null,
            };
        }
    }
}