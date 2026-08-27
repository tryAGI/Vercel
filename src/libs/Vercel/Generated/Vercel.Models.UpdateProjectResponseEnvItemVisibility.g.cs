
#nullable enable

namespace Vercel
{
    /// <summary>
    /// User-facing config/secret model. When set, authoritative for new code paths when the env-var-config-secret-ui flag is enabled. Legacy rows omit this field; legacy rows omit it and callers fall back to existing `type` behavior.
    /// </summary>
    public enum UpdateProjectResponseEnvItemVisibility
    {
        /// <summary>
        ///
        /// </summary>
        Config,
        /// <summary>
        ///
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseEnvItemVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseEnvItemVisibility value)
        {
            return value switch
            {
                UpdateProjectResponseEnvItemVisibility.Config => "config",
                UpdateProjectResponseEnvItemVisibility.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseEnvItemVisibility? ToEnum(string value)
        {
            return value switch
            {
                "config" => UpdateProjectResponseEnvItemVisibility.Config,
                "secret" => UpdateProjectResponseEnvItemVisibility.Secret,
                _ => null,
            };
        }
    }
}