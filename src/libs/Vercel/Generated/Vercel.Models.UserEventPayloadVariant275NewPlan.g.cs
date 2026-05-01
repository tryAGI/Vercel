
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant275NewPlan
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
    public static class UserEventPayloadVariant275NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant275NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant275NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant275NewPlan.Hobby => "hobby",
                UserEventPayloadVariant275NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant275NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant275NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant275NewPlan.Hobby,
                "pro" => UserEventPayloadVariant275NewPlan.Pro,
                _ => null,
            };
        }
    }
}