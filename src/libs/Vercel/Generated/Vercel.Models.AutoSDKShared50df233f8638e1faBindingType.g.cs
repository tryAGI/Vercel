
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKShared50df233f8638e1faBindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared50df233f8638e1faBindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared50df233f8638e1faBindingType value)
        {
            return value switch
            {
                AutoSDKShared50df233f8638e1faBindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared50df233f8638e1faBindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared50df233f8638e1faBindingType.Service,
                _ => null,
            };
        }
    }
}