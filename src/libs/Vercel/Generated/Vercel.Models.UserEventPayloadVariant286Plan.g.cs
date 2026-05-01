
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant286Plan
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
    public static class UserEventPayloadVariant286PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant286Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant286Plan.Enterprise => "enterprise",
                UserEventPayloadVariant286Plan.Hobby => "hobby",
                UserEventPayloadVariant286Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant286Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant286Plan.Enterprise,
                "hobby" => UserEventPayloadVariant286Plan.Hobby,
                "pro" => UserEventPayloadVariant286Plan.Pro,
                _ => null,
            };
        }
    }
}