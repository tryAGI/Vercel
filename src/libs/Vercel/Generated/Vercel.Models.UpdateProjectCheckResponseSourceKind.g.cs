
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectCheckResponseSourceKind
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
    public static class UpdateProjectCheckResponseSourceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectCheckResponseSourceKind value)
        {
            return value switch
            {
                UpdateProjectCheckResponseSourceKind.GitProvider => "git-provider",
                UpdateProjectCheckResponseSourceKind.Integration => "integration",
                UpdateProjectCheckResponseSourceKind.Vercel => "vercel",
                UpdateProjectCheckResponseSourceKind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectCheckResponseSourceKind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => UpdateProjectCheckResponseSourceKind.GitProvider,
                "integration" => UpdateProjectCheckResponseSourceKind.Integration,
                "vercel" => UpdateProjectCheckResponseSourceKind.Vercel,
                "webhook" => UpdateProjectCheckResponseSourceKind.Webhook,
                _ => null,
            };
        }
    }
}