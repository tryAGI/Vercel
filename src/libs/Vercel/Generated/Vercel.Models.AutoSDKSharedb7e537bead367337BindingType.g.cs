
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If present, must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum AutoSDKSharedb7e537bead367337BindingType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb7e537bead367337BindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb7e537bead367337BindingType value)
        {
            return value switch
            {
                AutoSDKSharedb7e537bead367337BindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb7e537bead367337BindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKSharedb7e537bead367337BindingType.Service,
                _ => null,
            };
        }
    }
}