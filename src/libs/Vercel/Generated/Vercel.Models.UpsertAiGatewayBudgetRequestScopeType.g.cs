
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpsertAiGatewayBudgetRequestScopeType
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
    public static class UpsertAiGatewayBudgetRequestScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertAiGatewayBudgetRequestScopeType value)
        {
            return value switch
            {
                UpsertAiGatewayBudgetRequestScopeType.Project => "project",
                UpsertAiGatewayBudgetRequestScopeType.Team => "team",
                UpsertAiGatewayBudgetRequestScopeType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertAiGatewayBudgetRequestScopeType? ToEnum(string value)
        {
            return value switch
            {
                "project" => UpsertAiGatewayBudgetRequestScopeType.Project,
                "team" => UpsertAiGatewayBudgetRequestScopeType.Team,
                "user" => UpsertAiGatewayBudgetRequestScopeType.User,
                _ => null,
            };
        }
    }
}