
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant282Plan
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
    public static class UserEventPayloadVariant282PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant282Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant282Plan.Enterprise => "enterprise",
                UserEventPayloadVariant282Plan.Hobby => "hobby",
                UserEventPayloadVariant282Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant282Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant282Plan.Enterprise,
                "hobby" => UserEventPayloadVariant282Plan.Hobby,
                "pro" => UserEventPayloadVariant282Plan.Pro,
                _ => null,
            };
        }
    }
}