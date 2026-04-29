
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant283Plan
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
    public static class UserEventPayloadVariant283PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant283Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant283Plan.Enterprise => "enterprise",
                UserEventPayloadVariant283Plan.Hobby => "hobby",
                UserEventPayloadVariant283Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant283Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant283Plan.Enterprise,
                "hobby" => UserEventPayloadVariant283Plan.Hobby,
                "pro" => UserEventPayloadVariant283Plan.Pro,
                _ => null,
            };
        }
    }
}