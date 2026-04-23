
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant257Environment
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
    public static class UserEventPayloadVariant257EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant257Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant257Environment.Preview => "preview",
                UserEventPayloadVariant257Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant257Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant257Environment.Preview,
                "production" => UserEventPayloadVariant257Environment.Production,
                _ => null,
            };
        }
    }
}