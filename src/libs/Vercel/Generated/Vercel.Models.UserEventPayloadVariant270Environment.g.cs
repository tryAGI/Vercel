
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant270Environment
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
    public static class UserEventPayloadVariant270EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant270Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant270Environment.Preview => "preview",
                UserEventPayloadVariant270Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant270Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant270Environment.Preview,
                "production" => UserEventPayloadVariant270Environment.Production,
                _ => null,
            };
        }
    }
}