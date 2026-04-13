
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant249Environment
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
    public static class UserEventPayloadVariant249EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant249Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant249Environment.Preview => "preview",
                UserEventPayloadVariant249Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant249Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant249Environment.Preview,
                "production" => UserEventPayloadVariant249Environment.Production,
                _ => null,
            };
        }
    }
}