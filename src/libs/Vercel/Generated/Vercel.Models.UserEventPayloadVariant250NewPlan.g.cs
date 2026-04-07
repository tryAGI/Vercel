
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant250NewPlan
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
    public static class UserEventPayloadVariant250NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant250NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant250NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant250NewPlan.Hobby => "hobby",
                UserEventPayloadVariant250NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant250NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant250NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant250NewPlan.Hobby,
                "pro" => UserEventPayloadVariant250NewPlan.Pro,
                _ => null,
            };
        }
    }
}