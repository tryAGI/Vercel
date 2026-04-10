
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant197ReasonCode
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
    public static class UserEventPayloadVariant197ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant197ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant197ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant197ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant197ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant197ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant197ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant197ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant197ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}