
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectCheckResponseSourceKind
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
    public static class CreateProjectCheckResponseSourceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectCheckResponseSourceKind value)
        {
            return value switch
            {
                CreateProjectCheckResponseSourceKind.GitProvider => "git-provider",
                CreateProjectCheckResponseSourceKind.Integration => "integration",
                CreateProjectCheckResponseSourceKind.Vercel => "vercel",
                CreateProjectCheckResponseSourceKind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectCheckResponseSourceKind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => CreateProjectCheckResponseSourceKind.GitProvider,
                "integration" => CreateProjectCheckResponseSourceKind.Integration,
                "vercel" => CreateProjectCheckResponseSourceKind.Vercel,
                "webhook" => CreateProjectCheckResponseSourceKind.Webhook,
                _ => null,
            };
        }
    }
}