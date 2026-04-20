
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant255Environment
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
    public static class UserEventPayloadVariant255EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant255Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant255Environment.Preview => "preview",
                UserEventPayloadVariant255Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant255Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant255Environment.Preview,
                "production" => UserEventPayloadVariant255Environment.Production,
                _ => null,
            };
        }
    }
}