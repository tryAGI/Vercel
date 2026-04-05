
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseChecksDeploymentAliasState
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
    public static class CreateDeploymentResponseChecksDeploymentAliasStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseChecksDeploymentAliasState value)
        {
            return value switch
            {
                CreateDeploymentResponseChecksDeploymentAliasState.Failed => "failed",
                CreateDeploymentResponseChecksDeploymentAliasState.Pending => "pending",
                CreateDeploymentResponseChecksDeploymentAliasState.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseChecksDeploymentAliasState? ToEnum(string value)
        {
            return value switch
            {
                "failed" => CreateDeploymentResponseChecksDeploymentAliasState.Failed,
                "pending" => CreateDeploymentResponseChecksDeploymentAliasState.Pending,
                "succeeded" => CreateDeploymentResponseChecksDeploymentAliasState.Succeeded,
                _ => null,
            };
        }
    }
}