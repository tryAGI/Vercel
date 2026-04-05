
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant264Scope
    {
        /// <summary>
        /// 
        /// </summary>
        Dashboard,
        /// <summary>
        /// 
        /// </summary>
        LogDrains,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant264ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant264Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant264Scope.Dashboard => "dashboard",
                UserEventPayloadVariant264Scope.LogDrains => "log-drains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant264Scope? ToEnum(string value)
        {
            return value switch
            {
                "dashboard" => UserEventPayloadVariant264Scope.Dashboard,
                "log-drains" => UserEventPayloadVariant264Scope.LogDrains,
                _ => null,
            };
        }
    }
}