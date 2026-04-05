
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant258Plan
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
    public static class UserEventPayloadVariant258PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant258Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant258Plan.Enterprise => "enterprise",
                UserEventPayloadVariant258Plan.Hobby => "hobby",
                UserEventPayloadVariant258Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant258Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant258Plan.Enterprise,
                "hobby" => UserEventPayloadVariant258Plan.Hobby,
                "pro" => UserEventPayloadVariant258Plan.Pro,
                _ => null,
            };
        }
    }
}