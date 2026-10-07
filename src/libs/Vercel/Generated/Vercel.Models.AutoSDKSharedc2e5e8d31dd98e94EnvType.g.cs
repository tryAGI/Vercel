
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc2e5e8d31dd98e94EnvType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc2e5e8d31dd98e94EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc2e5e8d31dd98e94EnvType value)
        {
            return value switch
            {
                AutoSDKSharedc2e5e8d31dd98e94EnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc2e5e8d31dd98e94EnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => AutoSDKSharedc2e5e8d31dd98e94EnvType.ServiceRef,
                _ => null,
            };
        }
    }
}