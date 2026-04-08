
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant195ReasonCode
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
    public static class UserEventPayloadVariant195ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant195ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant195ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant195ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant195ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant195ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant195ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant195ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant195ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}