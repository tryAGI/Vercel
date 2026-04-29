
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant265Environment
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
    public static class UserEventPayloadVariant265EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant265Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant265Environment.Preview => "preview",
                UserEventPayloadVariant265Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant265Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant265Environment.Preview,
                "production" => UserEventPayloadVariant265Environment.Production,
                _ => null,
            };
        }
    }
}