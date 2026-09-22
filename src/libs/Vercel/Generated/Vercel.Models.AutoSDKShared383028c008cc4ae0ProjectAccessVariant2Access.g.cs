
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0ProjectAccessVariant2Access
    {
        /// <summary>
        ///
        /// </summary>
        Some,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared383028c008cc4ae0ProjectAccessVariant2AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0ProjectAccessVariant2Access value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0ProjectAccessVariant2Access.Some => "some",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0ProjectAccessVariant2Access? ToEnum(string value)
        {
            return value switch
            {
                "some" => AutoSDKShared383028c008cc4ae0ProjectAccessVariant2Access.Some,
                _ => null,
            };
        }
    }
}