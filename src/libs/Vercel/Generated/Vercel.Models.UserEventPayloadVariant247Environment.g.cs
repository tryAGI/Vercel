
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant247Environment
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
    public static class UserEventPayloadVariant247EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant247Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant247Environment.Preview => "preview",
                UserEventPayloadVariant247Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant247Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant247Environment.Preview,
                "production" => UserEventPayloadVariant247Environment.Production,
                _ => null,
            };
        }
    }
}