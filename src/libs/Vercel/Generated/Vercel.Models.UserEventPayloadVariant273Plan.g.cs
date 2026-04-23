
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant273Plan
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
    public static class UserEventPayloadVariant273PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant273Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant273Plan.Enterprise => "enterprise",
                UserEventPayloadVariant273Plan.Hobby => "hobby",
                UserEventPayloadVariant273Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant273Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant273Plan.Enterprise,
                "hobby" => UserEventPayloadVariant273Plan.Hobby,
                "pro" => UserEventPayloadVariant273Plan.Pro,
                _ => null,
            };
        }
    }
}