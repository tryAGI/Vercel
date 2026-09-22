
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0FilterV2FilterVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared383028c008cc4ae0FilterV2FilterVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0FilterV2FilterVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0FilterV2FilterVariant1Type.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0FilterV2FilterVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared383028c008cc4ae0FilterV2FilterVariant1Type.Basic,
                _ => null,
            };
        }
    }
}