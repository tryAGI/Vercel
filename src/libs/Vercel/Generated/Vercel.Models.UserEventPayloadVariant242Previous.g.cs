
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant242Previous
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
    public static class UserEventPayloadVariant242PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant242Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant242Previous.Elastic => "elastic",
                UserEventPayloadVariant242Previous.Enhanced => "enhanced",
                UserEventPayloadVariant242Previous.Standard => "standard",
                UserEventPayloadVariant242Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant242Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant242Previous.Elastic,
                "enhanced" => UserEventPayloadVariant242Previous.Enhanced,
                "standard" => UserEventPayloadVariant242Previous.Standard,
                "turbo" => UserEventPayloadVariant242Previous.Turbo,
                _ => null,
            };
        }
    }
}