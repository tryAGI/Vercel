
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKShared87d7a4edbf209283BindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared87d7a4edbf209283BindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared87d7a4edbf209283BindingType value)
        {
            return value switch
            {
                AutoSDKShared87d7a4edbf209283BindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared87d7a4edbf209283BindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared87d7a4edbf209283BindingType.Service,
                _ => null,
            };
        }
    }
}