
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant212NextIssuerMode
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
    public static class UserEventPayloadVariant212NextIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant212NextIssuerMode value)
        {
            return value switch
            {
                UserEventPayloadVariant212NextIssuerMode.Global => "global",
                UserEventPayloadVariant212NextIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant212NextIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => UserEventPayloadVariant212NextIssuerMode.Global,
                "team" => UserEventPayloadVariant212NextIssuerMode.Team,
                _ => null,
            };
        }
    }
}