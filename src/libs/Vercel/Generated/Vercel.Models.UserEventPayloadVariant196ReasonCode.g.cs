
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant196ReasonCode
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
    public static class UserEventPayloadVariant196ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant196ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant196ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant196ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant196ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant196ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant196ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant196ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant196ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}