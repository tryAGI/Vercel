
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant266Environment
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
    public static class UserEventPayloadVariant266EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant266Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant266Environment.Preview => "preview",
                UserEventPayloadVariant266Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant266Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant266Environment.Preview,
                "production" => UserEventPayloadVariant266Environment.Production,
                _ => null,
            };
        }
    }
}