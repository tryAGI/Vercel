
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant203ReasonCode
    {
        /// <summary>
        /// 
        /// </summary>
        Backoffice,
        /// <summary>
        /// 
        /// </summary>
        BudgetReached,
        /// <summary>
        /// 
        /// </summary>
        PublicApi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant203ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant203ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant203ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant203ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant203ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant203ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant203ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant203ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant203ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}