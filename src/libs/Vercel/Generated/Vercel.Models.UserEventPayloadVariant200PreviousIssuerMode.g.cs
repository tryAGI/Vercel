
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant200PreviousIssuerMode
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
    public static class UserEventPayloadVariant200PreviousIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant200PreviousIssuerMode value)
        {
            return value switch
            {
                UserEventPayloadVariant200PreviousIssuerMode.Global => "global",
                UserEventPayloadVariant200PreviousIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant200PreviousIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => UserEventPayloadVariant200PreviousIssuerMode.Global,
                "team" => UserEventPayloadVariant200PreviousIssuerMode.Team,
                _ => null,
            };
        }
    }
}