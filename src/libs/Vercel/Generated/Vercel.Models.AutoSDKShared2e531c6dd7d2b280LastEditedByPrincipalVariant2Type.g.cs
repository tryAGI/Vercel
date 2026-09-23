
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2Type.App,
                _ => null,
            };
        }
    }
}