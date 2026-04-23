
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant254Next
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
    public static class UserEventPayloadVariant254NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant254Next value)
        {
            return value switch
            {
                UserEventPayloadVariant254Next.Elastic => "elastic",
                UserEventPayloadVariant254Next.Enhanced => "enhanced",
                UserEventPayloadVariant254Next.Standard => "standard",
                UserEventPayloadVariant254Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant254Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant254Next.Elastic,
                "enhanced" => UserEventPayloadVariant254Next.Enhanced,
                "standard" => UserEventPayloadVariant254Next.Standard,
                "turbo" => UserEventPayloadVariant254Next.Turbo,
                _ => null,
            };
        }
    }
}