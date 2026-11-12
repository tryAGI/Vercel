
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Directory Sync source, using existing local connection and organization authority rules.
    /// </summary>
    public enum TeamDirectorySyncSource
    {
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDirectorySyncSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDirectorySyncSource value)
        {
            return value switch
            {
                TeamDirectorySyncSource.None => "none",
                TeamDirectorySyncSource.Organization => "organization",
                TeamDirectorySyncSource.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDirectorySyncSource? ToEnum(string value)
        {
            return value switch
            {
                "none" => TeamDirectorySyncSource.None,
                "organization" => TeamDirectorySyncSource.Organization,
                "team" => TeamDirectorySyncSource.Team,
                _ => null,
            };
        }
    }
}