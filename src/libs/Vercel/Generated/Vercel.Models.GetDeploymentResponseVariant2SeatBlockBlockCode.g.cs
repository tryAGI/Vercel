
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The NSNB decision code for the seat block. TODO: We should consolidate block types.
    /// </summary>
    public enum GetDeploymentResponseVariant2SeatBlockBlockCode
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
    public static class GetDeploymentResponseVariant2SeatBlockBlockCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2SeatBlockBlockCode value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2SeatBlockBlockCode.CommitAuthorRequired => "COMMIT_AUTHOR_REQUIRED",
                GetDeploymentResponseVariant2SeatBlockBlockCode.TeamAccessRequired => "TEAM_ACCESS_REQUIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2SeatBlockBlockCode? ToEnum(string value)
        {
            return value switch
            {
                "COMMIT_AUTHOR_REQUIRED" => GetDeploymentResponseVariant2SeatBlockBlockCode.CommitAuthorRequired,
                "TEAM_ACCESS_REQUIRED" => GetDeploymentResponseVariant2SeatBlockBlockCode.TeamAccessRequired,
                _ => null,
            };
        }
    }
}