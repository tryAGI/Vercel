
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant212PreviousIssuerMode
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
    public static class UserEventPayloadVariant212PreviousIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant212PreviousIssuerMode value)
        {
            return value switch
            {
                UserEventPayloadVariant212PreviousIssuerMode.Global => "global",
                UserEventPayloadVariant212PreviousIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant212PreviousIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => UserEventPayloadVariant212PreviousIssuerMode.Global,
                "team" => UserEventPayloadVariant212PreviousIssuerMode.Team,
                _ => null,
            };
        }
    }
}