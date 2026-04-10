
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant267Scope
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
    public static class UserEventPayloadVariant267ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant267Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant267Scope.Dashboard => "dashboard",
                UserEventPayloadVariant267Scope.LogDrains => "log-drains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant267Scope? ToEnum(string value)
        {
            return value switch
            {
                "dashboard" => UserEventPayloadVariant267Scope.Dashboard,
                "log-drains" => UserEventPayloadVariant267Scope.LogDrains,
                _ => null,
            };
        }
    }
}