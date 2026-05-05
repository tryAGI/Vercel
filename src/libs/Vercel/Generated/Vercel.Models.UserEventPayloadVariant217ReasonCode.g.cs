
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant217ReasonCode
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
    public static class UserEventPayloadVariant217ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant217ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant217ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant217ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant217ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant217ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant217ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant217ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant217ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}