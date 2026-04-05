
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The NSNB decision code for the seat block. TODO: We should consolidate block types.
    /// </summary>
    public enum CreateDeploymentResponseSeatBlockBlockCode
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
    public static class CreateDeploymentResponseSeatBlockBlockCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseSeatBlockBlockCode value)
        {
            return value switch
            {
                CreateDeploymentResponseSeatBlockBlockCode.CommitAuthorRequired => "COMMIT_AUTHOR_REQUIRED",
                CreateDeploymentResponseSeatBlockBlockCode.TeamAccessRequired => "TEAM_ACCESS_REQUIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseSeatBlockBlockCode? ToEnum(string value)
        {
            return value switch
            {
                "COMMIT_AUTHOR_REQUIRED" => CreateDeploymentResponseSeatBlockBlockCode.CommitAuthorRequired,
                "TEAM_ACCESS_REQUIRED" => CreateDeploymentResponseSeatBlockBlockCode.TeamAccessRequired,
                _ => null,
            };
        }
    }
}