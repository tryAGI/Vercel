
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant207ReasonCode
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
    public static class UserEventPayloadVariant207ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant207ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant207ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant207ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant207ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant207ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant207ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant207ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant207ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}