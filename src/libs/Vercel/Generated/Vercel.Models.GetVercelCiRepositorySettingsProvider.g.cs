
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetVercelCiRepositorySettingsProvider
    {
        /// <summary>
        ///
        /// </summary>
        Bitbucket,
        /// <summary>
        ///
        /// </summary>
        CursorOrigin,
        /// <summary>
        ///
        /// </summary>
        Github,
        /// <summary>
        ///
        /// </summary>
        Gitlab,
        /// <summary>
        ///
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVercelCiRepositorySettingsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVercelCiRepositorySettingsProvider value)
        {
            return value switch
            {
                GetVercelCiRepositorySettingsProvider.Bitbucket => "bitbucket",
                GetVercelCiRepositorySettingsProvider.CursorOrigin => "cursor-origin",
                GetVercelCiRepositorySettingsProvider.Github => "github",
                GetVercelCiRepositorySettingsProvider.Gitlab => "gitlab",
                GetVercelCiRepositorySettingsProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVercelCiRepositorySettingsProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetVercelCiRepositorySettingsProvider.Bitbucket,
                "cursor-origin" => GetVercelCiRepositorySettingsProvider.CursorOrigin,
                "github" => GetVercelCiRepositorySettingsProvider.Github,
                "gitlab" => GetVercelCiRepositorySettingsProvider.Gitlab,
                "vercel" => GetVercelCiRepositorySettingsProvider.Vercel,
                _ => null,
            };
        }
    }
}