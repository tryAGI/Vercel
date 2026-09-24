
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4cd5b795d6ac66fcVariant6Type
    {
        /// <summary>
        ///
        /// </summary>
        GithubLimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared4cd5b795d6ac66fcVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4cd5b795d6ac66fcVariant6Type value)
        {
            return value switch
            {
                AutoSDKShared4cd5b795d6ac66fcVariant6Type.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4cd5b795d6ac66fcVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "github-limited" => AutoSDKShared4cd5b795d6ac66fcVariant6Type.GithubLimited,
                _ => null,
            };
        }
    }
}