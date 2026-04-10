
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant246Environment
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
    public static class UserEventPayloadVariant246EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant246Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant246Environment.Preview => "preview",
                UserEventPayloadVariant246Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant246Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant246Environment.Preview,
                "production" => UserEventPayloadVariant246Environment.Production,
                _ => null,
            };
        }
    }
}