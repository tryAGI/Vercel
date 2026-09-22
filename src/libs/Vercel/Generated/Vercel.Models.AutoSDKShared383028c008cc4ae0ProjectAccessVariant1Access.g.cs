
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0ProjectAccessVariant1Access
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared383028c008cc4ae0ProjectAccessVariant1AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0ProjectAccessVariant1Access value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0ProjectAccessVariant1Access.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0ProjectAccessVariant1Access? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared383028c008cc4ae0ProjectAccessVariant1Access.All,
                _ => null,
            };
        }
    }
}