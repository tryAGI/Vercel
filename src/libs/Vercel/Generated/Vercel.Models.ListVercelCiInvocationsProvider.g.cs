
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Repository provider (e.g., \"github\").
    /// </summary>
    public enum ListVercelCiInvocationsProvider
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
        /// <summary>
        ///
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListVercelCiInvocationsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVercelCiInvocationsProvider value)
        {
            return value switch
            {
                ListVercelCiInvocationsProvider.Bitbucket => "bitbucket",
                ListVercelCiInvocationsProvider.Github => "github",
                ListVercelCiInvocationsProvider.Gitlab => "gitlab",
                ListVercelCiInvocationsProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVercelCiInvocationsProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => ListVercelCiInvocationsProvider.Bitbucket,
                "github" => ListVercelCiInvocationsProvider.Github,
                "gitlab" => ListVercelCiInvocationsProvider.Gitlab,
                "vercel" => ListVercelCiInvocationsProvider.Vercel,
                _ => null,
            };
        }
    }
}