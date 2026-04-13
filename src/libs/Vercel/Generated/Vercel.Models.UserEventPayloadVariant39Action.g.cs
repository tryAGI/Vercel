
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant39Action
    {
        /// <summary>
        /// 
        /// </summary>
        CancelPlan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant39ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant39Action value)
        {
            return value switch
            {
                UserEventPayloadVariant39Action.CancelPlan => "cancel_plan",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant39Action? ToEnum(string value)
        {
            return value switch
            {
                "cancel_plan" => UserEventPayloadVariant39Action.CancelPlan,
                _ => null,
            };
        }
    }
}