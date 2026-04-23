
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant276Plan
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
    public static class UserEventPayloadVariant276PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant276Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant276Plan.Enterprise => "enterprise",
                UserEventPayloadVariant276Plan.Hobby => "hobby",
                UserEventPayloadVariant276Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant276Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant276Plan.Enterprise,
                "hobby" => UserEventPayloadVariant276Plan.Hobby,
                "pro" => UserEventPayloadVariant276Plan.Pro,
                _ => null,
            };
        }
    }
}