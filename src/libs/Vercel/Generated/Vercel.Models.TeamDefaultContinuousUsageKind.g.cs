
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default continuous-usage billing kind for projects under this team. Absent means projects stay unmetered.
    /// </summary>
    public enum TeamDefaultContinuousUsageKind
    {
        /// <summary>
        ///
        /// </summary>
        Metered,
        /// <summary>
        ///
        /// </summary>
        Unmetered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDefaultContinuousUsageKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDefaultContinuousUsageKind value)
        {
            return value switch
            {
                TeamDefaultContinuousUsageKind.Metered => "metered",
                TeamDefaultContinuousUsageKind.Unmetered => "unmetered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDefaultContinuousUsageKind? ToEnum(string value)
        {
            return value switch
            {
                "metered" => TeamDefaultContinuousUsageKind.Metered,
                "unmetered" => TeamDefaultContinuousUsageKind.Unmetered,
                _ => null,
            };
        }
    }
}