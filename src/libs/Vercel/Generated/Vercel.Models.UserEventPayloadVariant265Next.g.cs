
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant265Next
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
    public static class UserEventPayloadVariant265NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant265Next value)
        {
            return value switch
            {
                UserEventPayloadVariant265Next.Elastic => "elastic",
                UserEventPayloadVariant265Next.Enhanced => "enhanced",
                UserEventPayloadVariant265Next.Standard => "standard",
                UserEventPayloadVariant265Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant265Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant265Next.Elastic,
                "enhanced" => UserEventPayloadVariant265Next.Enhanced,
                "standard" => UserEventPayloadVariant265Next.Standard,
                "turbo" => UserEventPayloadVariant265Next.Turbo,
                _ => null,
            };
        }
    }
}