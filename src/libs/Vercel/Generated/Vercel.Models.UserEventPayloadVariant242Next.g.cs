
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant242Next
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
    public static class UserEventPayloadVariant242NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant242Next value)
        {
            return value switch
            {
                UserEventPayloadVariant242Next.Elastic => "elastic",
                UserEventPayloadVariant242Next.Enhanced => "enhanced",
                UserEventPayloadVariant242Next.Standard => "standard",
                UserEventPayloadVariant242Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant242Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant242Next.Elastic,
                "enhanced" => UserEventPayloadVariant242Next.Enhanced,
                "standard" => UserEventPayloadVariant242Next.Standard,
                "turbo" => UserEventPayloadVariant242Next.Turbo,
                _ => null,
            };
        }
    }
}