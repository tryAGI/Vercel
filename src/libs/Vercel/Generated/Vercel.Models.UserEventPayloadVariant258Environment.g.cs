
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant258Environment
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant258EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant258Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant258Environment.Preview => "preview",
                UserEventPayloadVariant258Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant258Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant258Environment.Preview,
                "production" => UserEventPayloadVariant258Environment.Production,
                _ => null,
            };
        }
    }
}