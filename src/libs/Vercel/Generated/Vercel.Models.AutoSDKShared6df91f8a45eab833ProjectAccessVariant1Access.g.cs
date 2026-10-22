
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833ProjectAccessVariant1Access
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6df91f8a45eab833ProjectAccessVariant1AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833ProjectAccessVariant1Access value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833ProjectAccessVariant1Access.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833ProjectAccessVariant1Access? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared6df91f8a45eab833ProjectAccessVariant1Access.All,
                _ => null,
            };
        }
    }
}