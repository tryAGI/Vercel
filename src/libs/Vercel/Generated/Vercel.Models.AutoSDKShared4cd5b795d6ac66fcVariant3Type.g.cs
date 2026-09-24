
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4cd5b795d6ac66fcVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        GithubCustomHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared4cd5b795d6ac66fcVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4cd5b795d6ac66fcVariant3Type value)
        {
            return value switch
            {
                AutoSDKShared4cd5b795d6ac66fcVariant3Type.GithubCustomHost => "github-custom-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4cd5b795d6ac66fcVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "github-custom-host" => AutoSDKShared4cd5b795d6ac66fcVariant3Type.GithubCustomHost,
                _ => null,
            };
        }
    }
}