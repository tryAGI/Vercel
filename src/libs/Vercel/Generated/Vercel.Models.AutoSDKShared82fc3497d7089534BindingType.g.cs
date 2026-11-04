
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKShared82fc3497d7089534BindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared82fc3497d7089534BindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared82fc3497d7089534BindingType value)
        {
            return value switch
            {
                AutoSDKShared82fc3497d7089534BindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared82fc3497d7089534BindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared82fc3497d7089534BindingType.Service,
                _ => null,
            };
        }
    }
}