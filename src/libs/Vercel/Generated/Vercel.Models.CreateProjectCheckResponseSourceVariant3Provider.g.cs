
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectCheckResponseSourceVariant3Provider
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
    public static class CreateProjectCheckResponseSourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectCheckResponseSourceVariant3Provider value)
        {
            return value switch
            {
                CreateProjectCheckResponseSourceVariant3Provider.Bitbucket => "bitbucket",
                CreateProjectCheckResponseSourceVariant3Provider.Github => "github",
                CreateProjectCheckResponseSourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectCheckResponseSourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateProjectCheckResponseSourceVariant3Provider.Bitbucket,
                "github" => CreateProjectCheckResponseSourceVariant3Provider.Github,
                "gitlab" => CreateProjectCheckResponseSourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}