
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant1Type.User,
                _ => null,
            };
        }
    }
}