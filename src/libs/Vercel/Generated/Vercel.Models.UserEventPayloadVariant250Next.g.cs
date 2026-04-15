
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant250Next
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
    public static class UserEventPayloadVariant250NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant250Next value)
        {
            return value switch
            {
                UserEventPayloadVariant250Next.Elastic => "elastic",
                UserEventPayloadVariant250Next.Enhanced => "enhanced",
                UserEventPayloadVariant250Next.Standard => "standard",
                UserEventPayloadVariant250Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant250Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant250Next.Elastic,
                "enhanced" => UserEventPayloadVariant250Next.Enhanced,
                "standard" => UserEventPayloadVariant250Next.Standard,
                "turbo" => UserEventPayloadVariant250Next.Turbo,
                _ => null,
            };
        }
    }
}