
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The advancement type of the rolling release<br/>
    /// Example: manual-approval
    /// </summary>
    public enum CompleteRollingReleaseResponseRollingReleaseAdvancementType
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
    public static class CompleteRollingReleaseResponseRollingReleaseAdvancementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteRollingReleaseResponseRollingReleaseAdvancementType value)
        {
            return value switch
            {
                CompleteRollingReleaseResponseRollingReleaseAdvancementType.Automatic => "automatic",
                CompleteRollingReleaseResponseRollingReleaseAdvancementType.ManualApproval => "manual-approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteRollingReleaseResponseRollingReleaseAdvancementType? ToEnum(string value)
        {
            return value switch
            {
                "automatic" => CompleteRollingReleaseResponseRollingReleaseAdvancementType.Automatic,
                "manual-approval" => CompleteRollingReleaseResponseRollingReleaseAdvancementType.ManualApproval,
                _ => null,
            };
        }
    }
}