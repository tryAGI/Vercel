
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpsertAiGatewayBudgetDefaultRequestScopeType
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
    public static class UpsertAiGatewayBudgetDefaultRequestScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertAiGatewayBudgetDefaultRequestScopeType value)
        {
            return value switch
            {
                UpsertAiGatewayBudgetDefaultRequestScopeType.ApiKey => "api-key",
                UpsertAiGatewayBudgetDefaultRequestScopeType.Project => "project",
                UpsertAiGatewayBudgetDefaultRequestScopeType.Team => "team",
                UpsertAiGatewayBudgetDefaultRequestScopeType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertAiGatewayBudgetDefaultRequestScopeType? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => UpsertAiGatewayBudgetDefaultRequestScopeType.ApiKey,
                "project" => UpsertAiGatewayBudgetDefaultRequestScopeType.Project,
                "team" => UpsertAiGatewayBudgetDefaultRequestScopeType.Team,
                "user" => UpsertAiGatewayBudgetDefaultRequestScopeType.User,
                _ => null,
            };
        }
    }
}