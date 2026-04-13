
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant245Next
    {
        /// <summary>
        /// 
        /// </summary>
        Elastic,
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant245NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant245Next value)
        {
            return value switch
            {
                UserEventPayloadVariant245Next.Elastic => "elastic",
                UserEventPayloadVariant245Next.Enhanced => "enhanced",
                UserEventPayloadVariant245Next.Standard => "standard",
                UserEventPayloadVariant245Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant245Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant245Next.Elastic,
                "enhanced" => UserEventPayloadVariant245Next.Enhanced,
                "standard" => UserEventPayloadVariant245Next.Standard,
                "turbo" => UserEventPayloadVariant245Next.Turbo,
                _ => null,
            };
        }
    }
}