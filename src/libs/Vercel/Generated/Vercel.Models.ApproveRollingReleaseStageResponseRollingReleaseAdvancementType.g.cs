
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The advancement type of the rolling release<br/>
    /// Example: manual-approval
    /// </summary>
    public enum ApproveRollingReleaseStageResponseRollingReleaseAdvancementType
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
    public static class ApproveRollingReleaseStageResponseRollingReleaseAdvancementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApproveRollingReleaseStageResponseRollingReleaseAdvancementType value)
        {
            return value switch
            {
                ApproveRollingReleaseStageResponseRollingReleaseAdvancementType.Automatic => "automatic",
                ApproveRollingReleaseStageResponseRollingReleaseAdvancementType.ManualApproval => "manual-approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApproveRollingReleaseStageResponseRollingReleaseAdvancementType? ToEnum(string value)
        {
            return value switch
            {
                "automatic" => ApproveRollingReleaseStageResponseRollingReleaseAdvancementType.Automatic,
                "manual-approval" => ApproveRollingReleaseStageResponseRollingReleaseAdvancementType.ManualApproval,
                _ => null,
            };
        }
    }
}