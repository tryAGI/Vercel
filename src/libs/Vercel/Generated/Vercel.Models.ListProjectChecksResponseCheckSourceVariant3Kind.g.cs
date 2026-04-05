
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectChecksResponseCheckSourceVariant3Kind
    {
        /// <summary>
        /// 
        /// </summary>
        GitProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectChecksResponseCheckSourceVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectChecksResponseCheckSourceVariant3Kind value)
        {
            return value switch
            {
                ListProjectChecksResponseCheckSourceVariant3Kind.GitProvider => "git-provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectChecksResponseCheckSourceVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => ListProjectChecksResponseCheckSourceVariant3Kind.GitProvider,
                _ => null,
            };
        }
    }
}