
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant37Action
    {
        /// <summary>
        /// 
        /// </summary>
        CancelPlan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant37ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant37Action value)
        {
            return value switch
            {
                UserEventPayloadVariant37Action.CancelPlan => "cancel_plan",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant37Action? ToEnum(string value)
        {
            return value switch
            {
                "cancel_plan" => UserEventPayloadVariant37Action.CancelPlan,
                _ => null,
            };
        }
    }
}