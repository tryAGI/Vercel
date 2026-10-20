
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede3c00aaf9d3a15beSourceVariant3Kind
    {
        /// <summary>
        ///
        /// </summary>
        GitProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede3c00aaf9d3a15beSourceVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede3c00aaf9d3a15beSourceVariant3Kind value)
        {
            return value switch
            {
                AutoSDKSharede3c00aaf9d3a15beSourceVariant3Kind.GitProvider => "git-provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede3c00aaf9d3a15beSourceVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => AutoSDKSharede3c00aaf9d3a15beSourceVariant3Kind.GitProvider,
                _ => null,
            };
        }
    }
}