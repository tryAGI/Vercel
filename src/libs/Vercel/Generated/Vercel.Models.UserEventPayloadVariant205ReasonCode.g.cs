
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant205ReasonCode
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
    public static class UserEventPayloadVariant205ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant205ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant205ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant205ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant205ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant205ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant205ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant205ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant205ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}