
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKSharedfeb17b1223c8bf77BindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfeb17b1223c8bf77BindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfeb17b1223c8bf77BindingType value)
        {
            return value switch
            {
                AutoSDKSharedfeb17b1223c8bf77BindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfeb17b1223c8bf77BindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKSharedfeb17b1223c8bf77BindingType.Service,
                _ => null,
            };
        }
    }
}