
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant262Previous
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
    public static class UserEventPayloadVariant262PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant262Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant262Previous.Elastic => "elastic",
                UserEventPayloadVariant262Previous.Enhanced => "enhanced",
                UserEventPayloadVariant262Previous.Standard => "standard",
                UserEventPayloadVariant262Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant262Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant262Previous.Elastic,
                "enhanced" => UserEventPayloadVariant262Previous.Enhanced,
                "standard" => UserEventPayloadVariant262Previous.Standard,
                "turbo" => UserEventPayloadVariant262Previous.Turbo,
                _ => null,
            };
        }
    }
}