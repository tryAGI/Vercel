
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseChecksDeploymentAliasState
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseChecksDeploymentAliasStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseChecksDeploymentAliasState value)
        {
            return value switch
            {
                CancelDeploymentResponseChecksDeploymentAliasState.Failed => "failed",
                CancelDeploymentResponseChecksDeploymentAliasState.Pending => "pending",
                CancelDeploymentResponseChecksDeploymentAliasState.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseChecksDeploymentAliasState? ToEnum(string value)
        {
            return value switch
            {
                "failed" => CancelDeploymentResponseChecksDeploymentAliasState.Failed,
                "pending" => CancelDeploymentResponseChecksDeploymentAliasState.Pending,
                "succeeded" => CancelDeploymentResponseChecksDeploymentAliasState.Succeeded,
                _ => null,
            };
        }
    }
}