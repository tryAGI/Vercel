
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Directory Sync source, using existing local connection and organization authority rules.
    /// </summary>
    public enum TeamLimitedDirectorySyncSource
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
    public static class TeamLimitedDirectorySyncSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamLimitedDirectorySyncSource value)
        {
            return value switch
            {
                TeamLimitedDirectorySyncSource.None => "none",
                TeamLimitedDirectorySyncSource.Organization => "organization",
                TeamLimitedDirectorySyncSource.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamLimitedDirectorySyncSource? ToEnum(string value)
        {
            return value switch
            {
                "none" => TeamLimitedDirectorySyncSource.None,
                "organization" => TeamLimitedDirectorySyncSource.Organization,
                "team" => TeamLimitedDirectorySyncSource.Team,
                _ => null,
            };
        }
    }
}