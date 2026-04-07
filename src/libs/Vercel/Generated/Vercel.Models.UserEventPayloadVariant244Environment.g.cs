
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant244Environment
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
    public static class UserEventPayloadVariant244EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant244Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant244Environment.Preview => "preview",
                UserEventPayloadVariant244Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant244Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant244Environment.Preview,
                "production" => UserEventPayloadVariant244Environment.Production,
                _ => null,
            };
        }
    }
}