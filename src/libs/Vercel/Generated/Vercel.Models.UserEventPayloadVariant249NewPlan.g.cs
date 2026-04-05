
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant249NewPlan
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
    public static class UserEventPayloadVariant249NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant249NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant249NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant249NewPlan.Hobby => "hobby",
                UserEventPayloadVariant249NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant249NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant249NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant249NewPlan.Hobby,
                "pro" => UserEventPayloadVariant249NewPlan.Pro,
                _ => null,
            };
        }
    }
}