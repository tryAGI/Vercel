
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The NSNB decision code for the seat block. TODO: We should consolidate block types.
    /// </summary>
    public enum GetDeploymentResponseVariant1SeatBlockBlockCode
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
    public static class GetDeploymentResponseVariant1SeatBlockBlockCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1SeatBlockBlockCode value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1SeatBlockBlockCode.CommitAuthorRequired => "COMMIT_AUTHOR_REQUIRED",
                GetDeploymentResponseVariant1SeatBlockBlockCode.TeamAccessRequired => "TEAM_ACCESS_REQUIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1SeatBlockBlockCode? ToEnum(string value)
        {
            return value switch
            {
                "COMMIT_AUTHOR_REQUIRED" => GetDeploymentResponseVariant1SeatBlockBlockCode.CommitAuthorRequired,
                "TEAM_ACCESS_REQUIRED" => GetDeploymentResponseVariant1SeatBlockBlockCode.TeamAccessRequired,
                _ => null,
            };
        }
    }
}