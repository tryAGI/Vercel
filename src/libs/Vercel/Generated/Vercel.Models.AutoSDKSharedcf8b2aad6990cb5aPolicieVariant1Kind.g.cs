
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcf8b2aad6990cb5aPolicieVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedcf8b2aad6990cb5aPolicieVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcf8b2aad6990cb5aPolicieVariant1Kind value)
        {
            return value switch
            {
                AutoSDKSharedcf8b2aad6990cb5aPolicieVariant1Kind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcf8b2aad6990cb5aPolicieVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => AutoSDKSharedcf8b2aad6990cb5aPolicieVariant1Kind.ProjectGrant,
                _ => null,
            };
        }
    }
}