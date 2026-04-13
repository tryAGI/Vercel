
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant199ReasonCode
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
    public static class UserEventPayloadVariant199ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant199ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant199ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant199ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant199ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant199ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant199ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant199ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant199ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}