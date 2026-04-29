
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant267Environment
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
    public static class UserEventPayloadVariant267EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant267Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant267Environment.Preview => "preview",
                UserEventPayloadVariant267Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant267Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant267Environment.Preview,
                "production" => UserEventPayloadVariant267Environment.Production,
                _ => null,
            };
        }
    }
}