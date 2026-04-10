
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant253PreviousPlan
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
    public static class UserEventPayloadVariant253PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant253PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant253PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant253PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant253PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant253PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant253PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant253PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant253PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}