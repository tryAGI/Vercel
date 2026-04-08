
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant251NewPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Hobby,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant251NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant251NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant251NewPlan.Hobby => "hobby",
                UserEventPayloadVariant251NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant251NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant251NewPlan.Hobby,
                "pro" => UserEventPayloadVariant251NewPlan.Pro,
                _ => null,
            };
        }
    }
}