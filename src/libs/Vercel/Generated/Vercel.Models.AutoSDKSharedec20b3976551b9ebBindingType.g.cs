
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKSharedec20b3976551b9ebBindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedec20b3976551b9ebBindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedec20b3976551b9ebBindingType value)
        {
            return value switch
            {
                AutoSDKSharedec20b3976551b9ebBindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedec20b3976551b9ebBindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKSharedec20b3976551b9ebBindingType.Service,
                _ => null,
            };
        }
    }
}