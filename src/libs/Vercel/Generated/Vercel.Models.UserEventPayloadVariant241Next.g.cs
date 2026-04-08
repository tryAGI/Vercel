
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant241Next
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
    public static class UserEventPayloadVariant241NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant241Next value)
        {
            return value switch
            {
                UserEventPayloadVariant241Next.Elastic => "elastic",
                UserEventPayloadVariant241Next.Enhanced => "enhanced",
                UserEventPayloadVariant241Next.Standard => "standard",
                UserEventPayloadVariant241Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant241Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant241Next.Elastic,
                "enhanced" => UserEventPayloadVariant241Next.Enhanced,
                "standard" => UserEventPayloadVariant241Next.Standard,
                "turbo" => UserEventPayloadVariant241Next.Turbo,
                _ => null,
            };
        }
    }
}