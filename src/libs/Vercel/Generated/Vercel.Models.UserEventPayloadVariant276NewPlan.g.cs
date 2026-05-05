
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant276NewPlan
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
    public static class UserEventPayloadVariant276NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant276NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant276NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant276NewPlan.Hobby => "hobby",
                UserEventPayloadVariant276NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant276NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant276NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant276NewPlan.Hobby,
                "pro" => UserEventPayloadVariant276NewPlan.Pro,
                _ => null,
            };
        }
    }
}