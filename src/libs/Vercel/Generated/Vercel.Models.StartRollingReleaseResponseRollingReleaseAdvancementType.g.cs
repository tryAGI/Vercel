
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The advancement type of the rolling release<br/>
    /// Example: manual-approval
    /// </summary>
    public enum StartRollingReleaseResponseRollingReleaseAdvancementType
    {
        /// <summary>
        ///
        /// </summary>
        Automatic,
        /// <summary>
        ///
        /// </summary>
        ManualApproval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartRollingReleaseResponseRollingReleaseAdvancementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartRollingReleaseResponseRollingReleaseAdvancementType value)
        {
            return value switch
            {
                StartRollingReleaseResponseRollingReleaseAdvancementType.Automatic => "automatic",
                StartRollingReleaseResponseRollingReleaseAdvancementType.ManualApproval => "manual-approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartRollingReleaseResponseRollingReleaseAdvancementType? ToEnum(string value)
        {
            return value switch
            {
                "automatic" => StartRollingReleaseResponseRollingReleaseAdvancementType.Automatic,
                "manual-approval" => StartRollingReleaseResponseRollingReleaseAdvancementType.ManualApproval,
                _ => null,
            };
        }
    }
}