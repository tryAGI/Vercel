
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKShared5d941fd0946ddd47BindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared5d941fd0946ddd47BindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5d941fd0946ddd47BindingType value)
        {
            return value switch
            {
                AutoSDKShared5d941fd0946ddd47BindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5d941fd0946ddd47BindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared5d941fd0946ddd47BindingType.Service,
                _ => null,
            };
        }
    }
}