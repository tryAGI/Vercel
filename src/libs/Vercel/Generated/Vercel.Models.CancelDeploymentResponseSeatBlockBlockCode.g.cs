
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The NSNB decision code for the seat block. TODO: We should consolidate block types.
    /// </summary>
    public enum CancelDeploymentResponseSeatBlockBlockCode
    {
        /// <summary>
        /// 
        /// </summary>
        CommitAuthorRequired,
        /// <summary>
        /// 
        /// </summary>
        TeamAccessRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseSeatBlockBlockCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseSeatBlockBlockCode value)
        {
            return value switch
            {
                CancelDeploymentResponseSeatBlockBlockCode.CommitAuthorRequired => "COMMIT_AUTHOR_REQUIRED",
                CancelDeploymentResponseSeatBlockBlockCode.TeamAccessRequired => "TEAM_ACCESS_REQUIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseSeatBlockBlockCode? ToEnum(string value)
        {
            return value switch
            {
                "COMMIT_AUTHOR_REQUIRED" => CancelDeploymentResponseSeatBlockBlockCode.CommitAuthorRequired,
                "TEAM_ACCESS_REQUIRED" => CancelDeploymentResponseSeatBlockBlockCode.TeamAccessRequired,
                _ => null,
            };
        }
    }
}