
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant197NextIssuerMode
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
    public static class UserEventPayloadVariant197NextIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant197NextIssuerMode value)
        {
            return value switch
            {
                UserEventPayloadVariant197NextIssuerMode.Global => "global",
                UserEventPayloadVariant197NextIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant197NextIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => UserEventPayloadVariant197NextIssuerMode.Global,
                "team" => UserEventPayloadVariant197NextIssuerMode.Team,
                _ => null,
            };
        }
    }
}