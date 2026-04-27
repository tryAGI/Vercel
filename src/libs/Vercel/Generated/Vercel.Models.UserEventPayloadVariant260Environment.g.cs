
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant260Environment
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
    public static class UserEventPayloadVariant260EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant260Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant260Environment.Preview => "preview",
                UserEventPayloadVariant260Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant260Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant260Environment.Preview,
                "production" => UserEventPayloadVariant260Environment.Production,
                _ => null,
            };
        }
    }
}