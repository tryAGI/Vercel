
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateVercelCiRepositorySettingsProvider
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
    public static class UpdateVercelCiRepositorySettingsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateVercelCiRepositorySettingsProvider value)
        {
            return value switch
            {
                UpdateVercelCiRepositorySettingsProvider.Bitbucket => "bitbucket",
                UpdateVercelCiRepositorySettingsProvider.CursorOrigin => "cursor-origin",
                UpdateVercelCiRepositorySettingsProvider.Github => "github",
                UpdateVercelCiRepositorySettingsProvider.Gitlab => "gitlab",
                UpdateVercelCiRepositorySettingsProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateVercelCiRepositorySettingsProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateVercelCiRepositorySettingsProvider.Bitbucket,
                "cursor-origin" => UpdateVercelCiRepositorySettingsProvider.CursorOrigin,
                "github" => UpdateVercelCiRepositorySettingsProvider.Github,
                "gitlab" => UpdateVercelCiRepositorySettingsProvider.Gitlab,
                "vercel" => UpdateVercelCiRepositorySettingsProvider.Vercel,
                _ => null,
            };
        }
    }
}