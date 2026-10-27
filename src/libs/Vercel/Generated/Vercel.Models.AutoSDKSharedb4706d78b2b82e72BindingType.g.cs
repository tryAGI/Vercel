
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKSharedb4706d78b2b82e72BindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb4706d78b2b82e72BindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb4706d78b2b82e72BindingType value)
        {
            return value switch
            {
                AutoSDKSharedb4706d78b2b82e72BindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb4706d78b2b82e72BindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKSharedb4706d78b2b82e72BindingType.Service,
                _ => null,
            };
        }
    }
}