
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared12773eaec07789a9SourceVariant3Kind
    {
        /// <summary>
        ///
        /// </summary>
        GitProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared12773eaec07789a9SourceVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared12773eaec07789a9SourceVariant3Kind value)
        {
            return value switch
            {
                AutoSDKShared12773eaec07789a9SourceVariant3Kind.GitProvider => "git-provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared12773eaec07789a9SourceVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => AutoSDKShared12773eaec07789a9SourceVariant3Kind.GitProvider,
                _ => null,
            };
        }
    }
}