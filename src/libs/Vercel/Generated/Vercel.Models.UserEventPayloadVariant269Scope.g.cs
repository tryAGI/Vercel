
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant269Scope
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
    public static class UserEventPayloadVariant269ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant269Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant269Scope.Dashboard => "dashboard",
                UserEventPayloadVariant269Scope.LogDrains => "log-drains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant269Scope? ToEnum(string value)
        {
            return value switch
            {
                "dashboard" => UserEventPayloadVariant269Scope.Dashboard,
                "log-drains" => UserEventPayloadVariant269Scope.LogDrains,
                _ => null,
            };
        }
    }
}