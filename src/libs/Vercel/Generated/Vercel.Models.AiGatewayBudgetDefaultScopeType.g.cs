
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AiGatewayBudgetDefaultScopeType
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
    public static class AiGatewayBudgetDefaultScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayBudgetDefaultScopeType value)
        {
            return value switch
            {
                AiGatewayBudgetDefaultScopeType.ApiKey => "api-key",
                AiGatewayBudgetDefaultScopeType.Project => "project",
                AiGatewayBudgetDefaultScopeType.Team => "team",
                AiGatewayBudgetDefaultScopeType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayBudgetDefaultScopeType? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => AiGatewayBudgetDefaultScopeType.ApiKey,
                "project" => AiGatewayBudgetDefaultScopeType.Project,
                "team" => AiGatewayBudgetDefaultScopeType.Team,
                "user" => AiGatewayBudgetDefaultScopeType.User,
                _ => null,
            };
        }
    }
}