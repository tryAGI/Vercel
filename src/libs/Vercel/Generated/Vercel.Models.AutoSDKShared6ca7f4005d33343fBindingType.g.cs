
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKShared6ca7f4005d33343fBindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6ca7f4005d33343fBindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ca7f4005d33343fBindingType value)
        {
            return value switch
            {
                AutoSDKShared6ca7f4005d33343fBindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ca7f4005d33343fBindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared6ca7f4005d33343fBindingType.Service,
                _ => null,
            };
        }
    }
}