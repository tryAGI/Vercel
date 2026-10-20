
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared78bd7b18568312c4EnvType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared78bd7b18568312c4EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared78bd7b18568312c4EnvType value)
        {
            return value switch
            {
                AutoSDKShared78bd7b18568312c4EnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared78bd7b18568312c4EnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => AutoSDKShared78bd7b18568312c4EnvType.ServiceRef,
                _ => null,
            };
        }
    }
}