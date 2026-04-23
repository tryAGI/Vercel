
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant282Scope
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
    public static class UserEventPayloadVariant282ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant282Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant282Scope.Dashboard => "dashboard",
                UserEventPayloadVariant282Scope.LogDrains => "log-drains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant282Scope? ToEnum(string value)
        {
            return value switch
            {
                "dashboard" => UserEventPayloadVariant282Scope.Dashboard,
                "log-drains" => UserEventPayloadVariant282Scope.LogDrains,
                _ => null,
            };
        }
    }
}