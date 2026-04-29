
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant10FromPlan
    {
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
    public static class UserEventPayloadVariant10FromPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant10FromPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant10FromPlan.Hobby => "hobby",
                UserEventPayloadVariant10FromPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant10FromPlan? ToEnum(string value)
        {
            return value switch
            {
                "hobby" => UserEventPayloadVariant10FromPlan.Hobby,
                "pro" => UserEventPayloadVariant10FromPlan.Pro,
                _ => null,
            };
        }
    }
}