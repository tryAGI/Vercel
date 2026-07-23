
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2ChecksDeploymentAliasState
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
    public static class GetDeploymentResponseVariant2ChecksDeploymentAliasStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ChecksDeploymentAliasState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ChecksDeploymentAliasState.Failed => "failed",
                GetDeploymentResponseVariant2ChecksDeploymentAliasState.Pending => "pending",
                GetDeploymentResponseVariant2ChecksDeploymentAliasState.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ChecksDeploymentAliasState? ToEnum(string value)
        {
            return value switch
            {
                "failed" => GetDeploymentResponseVariant2ChecksDeploymentAliasState.Failed,
                "pending" => GetDeploymentResponseVariant2ChecksDeploymentAliasState.Pending,
                "succeeded" => GetDeploymentResponseVariant2ChecksDeploymentAliasState.Succeeded,
                _ => null,
            };
        }
    }
}