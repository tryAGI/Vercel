
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant200NextIssuerMode
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant200NextIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant200NextIssuerMode value)
        {
            return value switch
            {
                UserEventPayloadVariant200NextIssuerMode.Global => "global",
                UserEventPayloadVariant200NextIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant200NextIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => UserEventPayloadVariant200NextIssuerMode.Global,
                "team" => UserEventPayloadVariant200NextIssuerMode.Team,
                _ => null,
            };
        }
    }
}