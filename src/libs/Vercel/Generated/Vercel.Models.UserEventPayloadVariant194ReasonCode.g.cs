
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant194ReasonCode
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
    public static class UserEventPayloadVariant194ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant194ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant194ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant194ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant194ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant194ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant194ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant194ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant194ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}