
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The advancement type of the rolling release<br/>
    /// Example: manual-approval
    /// </summary>
    public enum GetRollingReleaseResponseRollingReleaseAdvancementType
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
    public static class GetRollingReleaseResponseRollingReleaseAdvancementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseResponseRollingReleaseAdvancementType value)
        {
            return value switch
            {
                GetRollingReleaseResponseRollingReleaseAdvancementType.Automatic => "automatic",
                GetRollingReleaseResponseRollingReleaseAdvancementType.ManualApproval => "manual-approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseResponseRollingReleaseAdvancementType? ToEnum(string value)
        {
            return value switch
            {
                "automatic" => GetRollingReleaseResponseRollingReleaseAdvancementType.Automatic,
                "manual-approval" => GetRollingReleaseResponseRollingReleaseAdvancementType.ManualApproval,
                _ => null,
            };
        }
    }
}