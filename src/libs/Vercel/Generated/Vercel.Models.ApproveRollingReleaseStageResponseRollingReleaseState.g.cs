
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The current state of the rolling release<br/>
    /// Example: ACTIVE
    /// </summary>
    public enum ApproveRollingReleaseStageResponseRollingReleaseState
    {
        /// <summary>
        /// 
        /// </summary>
        Aborted,
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Complete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApproveRollingReleaseStageResponseRollingReleaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApproveRollingReleaseStageResponseRollingReleaseState value)
        {
            return value switch
            {
                ApproveRollingReleaseStageResponseRollingReleaseState.Aborted => "ABORTED",
                ApproveRollingReleaseStageResponseRollingReleaseState.Active => "ACTIVE",
                ApproveRollingReleaseStageResponseRollingReleaseState.Complete => "COMPLETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApproveRollingReleaseStageResponseRollingReleaseState? ToEnum(string value)
        {
            return value switch
            {
                "ABORTED" => ApproveRollingReleaseStageResponseRollingReleaseState.Aborted,
                "ACTIVE" => ApproveRollingReleaseStageResponseRollingReleaseState.Active,
                "COMPLETE" => ApproveRollingReleaseStageResponseRollingReleaseState.Complete,
                _ => null,
            };
        }
    }
}