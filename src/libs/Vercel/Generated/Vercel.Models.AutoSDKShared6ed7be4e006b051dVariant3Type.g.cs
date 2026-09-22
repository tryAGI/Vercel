
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed7be4e006b051dVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6ed7be4e006b051dVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed7be4e006b051dVariant3Type value)
        {
            return value switch
            {
                AutoSDKShared6ed7be4e006b051dVariant3Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed7be4e006b051dVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => AutoSDKShared6ed7be4e006b051dVariant3Type.Bitbucket,
                _ => null,
            };
        }
    }
}