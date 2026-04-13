
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant248Environment
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
    public static class UserEventPayloadVariant248EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant248Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant248Environment.Preview => "preview",
                UserEventPayloadVariant248Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant248Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant248Environment.Preview,
                "production" => UserEventPayloadVariant248Environment.Production,
                _ => null,
            };
        }
    }
}