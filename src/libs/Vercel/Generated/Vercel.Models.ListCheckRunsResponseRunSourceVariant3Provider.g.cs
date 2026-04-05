
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunSourceVariant3Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCheckRunsResponseRunSourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunSourceVariant3Provider value)
        {
            return value switch
            {
                ListCheckRunsResponseRunSourceVariant3Provider.Bitbucket => "bitbucket",
                ListCheckRunsResponseRunSourceVariant3Provider.Github => "github",
                ListCheckRunsResponseRunSourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunSourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => ListCheckRunsResponseRunSourceVariant3Provider.Bitbucket,
                "github" => ListCheckRunsResponseRunSourceVariant3Provider.Github,
                "gitlab" => ListCheckRunsResponseRunSourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}