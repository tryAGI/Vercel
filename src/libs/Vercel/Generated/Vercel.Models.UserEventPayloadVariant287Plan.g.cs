
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant287Plan
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
    public static class UserEventPayloadVariant287PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant287Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant287Plan.Enterprise => "enterprise",
                UserEventPayloadVariant287Plan.Hobby => "hobby",
                UserEventPayloadVariant287Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant287Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant287Plan.Enterprise,
                "hobby" => UserEventPayloadVariant287Plan.Hobby,
                "pro" => UserEventPayloadVariant287Plan.Pro,
                _ => null,
            };
        }
    }
}