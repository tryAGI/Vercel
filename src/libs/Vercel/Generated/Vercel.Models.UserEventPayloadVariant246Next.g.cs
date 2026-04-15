
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant246Next
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
    public static class UserEventPayloadVariant246NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant246Next value)
        {
            return value switch
            {
                UserEventPayloadVariant246Next.Elastic => "elastic",
                UserEventPayloadVariant246Next.Enhanced => "enhanced",
                UserEventPayloadVariant246Next.Standard => "standard",
                UserEventPayloadVariant246Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant246Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant246Next.Elastic,
                "enhanced" => UserEventPayloadVariant246Next.Enhanced,
                "standard" => UserEventPayloadVariant246Next.Standard,
                "turbo" => UserEventPayloadVariant246Next.Turbo,
                _ => null,
            };
        }
    }
}