
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKShared922c97954e29e8b6DaemonBindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared922c97954e29e8b6DaemonBindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared922c97954e29e8b6DaemonBindingType value)
        {
            return value switch
            {
                AutoSDKShared922c97954e29e8b6DaemonBindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared922c97954e29e8b6DaemonBindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared922c97954e29e8b6DaemonBindingType.Service,
                _ => null,
            };
        }
    }
}