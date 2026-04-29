
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant262Next
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
    public static class UserEventPayloadVariant262NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant262Next value)
        {
            return value switch
            {
                UserEventPayloadVariant262Next.Elastic => "elastic",
                UserEventPayloadVariant262Next.Enhanced => "enhanced",
                UserEventPayloadVariant262Next.Standard => "standard",
                UserEventPayloadVariant262Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant262Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant262Next.Elastic,
                "enhanced" => UserEventPayloadVariant262Next.Enhanced,
                "standard" => UserEventPayloadVariant262Next.Standard,
                "turbo" => UserEventPayloadVariant262Next.Turbo,
                _ => null,
            };
        }
    }
}