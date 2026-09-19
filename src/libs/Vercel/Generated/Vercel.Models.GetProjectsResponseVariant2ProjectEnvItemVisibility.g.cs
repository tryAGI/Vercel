
#nullable enable

namespace Vercel
{
    /// <summary>
    /// User-facing config/secret model. When set, authoritative for new code paths. Legacy rows omit this field and callers fall back to existing `type` behavior.
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectEnvItemVisibility
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
    public static class GetProjectsResponseVariant2ProjectEnvItemVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectEnvItemVisibility value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectEnvItemVisibility.Config => "config",
                GetProjectsResponseVariant2ProjectEnvItemVisibility.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectEnvItemVisibility? ToEnum(string value)
        {
            return value switch
            {
                "config" => GetProjectsResponseVariant2ProjectEnvItemVisibility.Config,
                "secret" => GetProjectsResponseVariant2ProjectEnvItemVisibility.Secret,
                _ => null,
            };
        }
    }
}