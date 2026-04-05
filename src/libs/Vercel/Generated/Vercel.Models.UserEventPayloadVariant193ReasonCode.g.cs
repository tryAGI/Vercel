
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant193ReasonCode
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
    public static class UserEventPayloadVariant193ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant193ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant193ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant193ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant193ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant193ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant193ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant193ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant193ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}