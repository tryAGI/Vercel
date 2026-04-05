
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectChecksResponseCheckSourceKind
    {
        /// <summary>
        /// 
        /// </summary>
        GitProvider,
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        Vercel,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectChecksResponseCheckSourceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectChecksResponseCheckSourceKind value)
        {
            return value switch
            {
                ListProjectChecksResponseCheckSourceKind.GitProvider => "git-provider",
                ListProjectChecksResponseCheckSourceKind.Integration => "integration",
                ListProjectChecksResponseCheckSourceKind.Vercel => "vercel",
                ListProjectChecksResponseCheckSourceKind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectChecksResponseCheckSourceKind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => ListProjectChecksResponseCheckSourceKind.GitProvider,
                "integration" => ListProjectChecksResponseCheckSourceKind.Integration,
                "vercel" => ListProjectChecksResponseCheckSourceKind.Vercel,
                "webhook" => ListProjectChecksResponseCheckSourceKind.Webhook,
                _ => null,
            };
        }
    }
}