
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared303c00bc2455dd70EnvType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared303c00bc2455dd70EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared303c00bc2455dd70EnvType value)
        {
            return value switch
            {
                AutoSDKShared303c00bc2455dd70EnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared303c00bc2455dd70EnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => AutoSDKShared303c00bc2455dd70EnvType.ServiceRef,
                _ => null,
            };
        }
    }
}