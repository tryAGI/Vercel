
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKShared758f1bb5042637ceBindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared758f1bb5042637ceBindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared758f1bb5042637ceBindingType value)
        {
            return value switch
            {
                AutoSDKShared758f1bb5042637ceBindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared758f1bb5042637ceBindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared758f1bb5042637ceBindingType.Service,
                _ => null,
            };
        }
    }
}