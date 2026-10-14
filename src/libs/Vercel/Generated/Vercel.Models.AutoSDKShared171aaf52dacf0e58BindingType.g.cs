
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKShared171aaf52dacf0e58BindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared171aaf52dacf0e58BindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared171aaf52dacf0e58BindingType value)
        {
            return value switch
            {
                AutoSDKShared171aaf52dacf0e58BindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared171aaf52dacf0e58BindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared171aaf52dacf0e58BindingType.Service,
                _ => null,
            };
        }
    }
}