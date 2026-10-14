
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared97ad06bd8a349d59EnvType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared97ad06bd8a349d59EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared97ad06bd8a349d59EnvType value)
        {
            return value switch
            {
                AutoSDKShared97ad06bd8a349d59EnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared97ad06bd8a349d59EnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => AutoSDKShared97ad06bd8a349d59EnvType.ServiceRef,
                _ => null,
            };
        }
    }
}