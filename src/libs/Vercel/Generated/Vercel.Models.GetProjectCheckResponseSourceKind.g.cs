
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectCheckResponseSourceKind
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
    public static class GetProjectCheckResponseSourceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectCheckResponseSourceKind value)
        {
            return value switch
            {
                GetProjectCheckResponseSourceKind.GitProvider => "git-provider",
                GetProjectCheckResponseSourceKind.Integration => "integration",
                GetProjectCheckResponseSourceKind.Vercel => "vercel",
                GetProjectCheckResponseSourceKind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectCheckResponseSourceKind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => GetProjectCheckResponseSourceKind.GitProvider,
                "integration" => GetProjectCheckResponseSourceKind.Integration,
                "vercel" => GetProjectCheckResponseSourceKind.Vercel,
                "webhook" => GetProjectCheckResponseSourceKind.Webhook,
                _ => null,
            };
        }
    }
}