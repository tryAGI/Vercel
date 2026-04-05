
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The NSNB decision code for the seat block. TODO: We should consolidate block types.
    /// </summary>
    public enum GetDeploymentsResponseDeploymentSeatBlockBlockCode
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
    public static class GetDeploymentsResponseDeploymentSeatBlockBlockCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentSeatBlockBlockCode value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentSeatBlockBlockCode.CommitAuthorRequired => "COMMIT_AUTHOR_REQUIRED",
                GetDeploymentsResponseDeploymentSeatBlockBlockCode.TeamAccessRequired => "TEAM_ACCESS_REQUIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentSeatBlockBlockCode? ToEnum(string value)
        {
            return value switch
            {
                "COMMIT_AUTHOR_REQUIRED" => GetDeploymentsResponseDeploymentSeatBlockBlockCode.CommitAuthorRequired,
                "TEAM_ACCESS_REQUIRED" => GetDeploymentsResponseDeploymentSeatBlockBlockCode.TeamAccessRequired,
                _ => null,
            };
        }
    }
}