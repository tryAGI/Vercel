
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant206ReasonCode
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
    public static class UserEventPayloadVariant206ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant206ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant206ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant206ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant206ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant206ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant206ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant206ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant206ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}