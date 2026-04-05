
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectCheckResponseSourceVariant3Provider
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
    public static class UpdateProjectCheckResponseSourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectCheckResponseSourceVariant3Provider value)
        {
            return value switch
            {
                UpdateProjectCheckResponseSourceVariant3Provider.Bitbucket => "bitbucket",
                UpdateProjectCheckResponseSourceVariant3Provider.Github => "github",
                UpdateProjectCheckResponseSourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectCheckResponseSourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateProjectCheckResponseSourceVariant3Provider.Bitbucket,
                "github" => UpdateProjectCheckResponseSourceVariant3Provider.Github,
                "gitlab" => UpdateProjectCheckResponseSourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}