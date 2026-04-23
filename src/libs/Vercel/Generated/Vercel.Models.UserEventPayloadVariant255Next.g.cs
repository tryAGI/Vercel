
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant255Next
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
    public static class UserEventPayloadVariant255NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant255Next value)
        {
            return value switch
            {
                UserEventPayloadVariant255Next.Elastic => "elastic",
                UserEventPayloadVariant255Next.Enhanced => "enhanced",
                UserEventPayloadVariant255Next.Standard => "standard",
                UserEventPayloadVariant255Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant255Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant255Next.Elastic,
                "enhanced" => UserEventPayloadVariant255Next.Enhanced,
                "standard" => UserEventPayloadVariant255Next.Standard,
                "turbo" => UserEventPayloadVariant255Next.Turbo,
                _ => null,
            };
        }
    }
}