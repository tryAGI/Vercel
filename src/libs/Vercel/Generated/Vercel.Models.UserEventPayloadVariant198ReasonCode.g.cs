
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant198ReasonCode
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
    public static class UserEventPayloadVariant198ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant198ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant198ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant198ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant198ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant198ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant198ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant198ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant198ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}