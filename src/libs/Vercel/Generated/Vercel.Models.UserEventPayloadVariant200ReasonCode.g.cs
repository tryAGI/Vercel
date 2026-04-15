
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant200ReasonCode
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
    public static class UserEventPayloadVariant200ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant200ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant200ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant200ReasonCode.BudgetReached => "BUDGET_REACHED",
                UserEventPayloadVariant200ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant200ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant200ReasonCode.Backoffice,
                "BUDGET_REACHED" => UserEventPayloadVariant200ReasonCode.BudgetReached,
                "PUBLIC_API" => UserEventPayloadVariant200ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}