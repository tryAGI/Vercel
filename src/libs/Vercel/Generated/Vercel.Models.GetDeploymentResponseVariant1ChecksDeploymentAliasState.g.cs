
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ChecksDeploymentAliasState
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
    public static class GetDeploymentResponseVariant1ChecksDeploymentAliasStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ChecksDeploymentAliasState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ChecksDeploymentAliasState.Failed => "failed",
                GetDeploymentResponseVariant1ChecksDeploymentAliasState.Pending => "pending",
                GetDeploymentResponseVariant1ChecksDeploymentAliasState.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ChecksDeploymentAliasState? ToEnum(string value)
        {
            return value switch
            {
                "failed" => GetDeploymentResponseVariant1ChecksDeploymentAliasState.Failed,
                "pending" => GetDeploymentResponseVariant1ChecksDeploymentAliasState.Pending,
                "succeeded" => GetDeploymentResponseVariant1ChecksDeploymentAliasState.Succeeded,
                _ => null,
            };
        }
    }
}