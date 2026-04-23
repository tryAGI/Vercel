
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant259Environment
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
    public static class UserEventPayloadVariant259EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant259Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant259Environment.Preview => "preview",
                UserEventPayloadVariant259Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant259Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant259Environment.Preview,
                "production" => UserEventPayloadVariant259Environment.Production,
                _ => null,
            };
        }
    }
}