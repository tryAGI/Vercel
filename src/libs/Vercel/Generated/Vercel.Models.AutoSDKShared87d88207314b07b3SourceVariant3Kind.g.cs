
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared87d88207314b07b3SourceVariant3Kind
    {
        /// <summary>
        ///
        /// </summary>
        GitProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared87d88207314b07b3SourceVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared87d88207314b07b3SourceVariant3Kind value)
        {
            return value switch
            {
                AutoSDKShared87d88207314b07b3SourceVariant3Kind.GitProvider => "git-provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared87d88207314b07b3SourceVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => AutoSDKShared87d88207314b07b3SourceVariant3Kind.GitProvider,
                _ => null,
            };
        }
    }
}