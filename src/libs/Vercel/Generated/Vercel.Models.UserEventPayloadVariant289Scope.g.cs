
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant289Scope
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
    public static class UserEventPayloadVariant289ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant289Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant289Scope.Dashboard => "dashboard",
                UserEventPayloadVariant289Scope.LogDrains => "log-drains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant289Scope? ToEnum(string value)
        {
            return value switch
            {
                "dashboard" => UserEventPayloadVariant289Scope.Dashboard,
                "log-drains" => UserEventPayloadVariant289Scope.LogDrains,
                _ => null,
            };
        }
    }
}