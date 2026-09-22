
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared32260c85dfc16e39EnvType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared32260c85dfc16e39EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared32260c85dfc16e39EnvType value)
        {
            return value switch
            {
                AutoSDKShared32260c85dfc16e39EnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared32260c85dfc16e39EnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => AutoSDKShared32260c85dfc16e39EnvType.ServiceRef,
                _ => null,
            };
        }
    }
}