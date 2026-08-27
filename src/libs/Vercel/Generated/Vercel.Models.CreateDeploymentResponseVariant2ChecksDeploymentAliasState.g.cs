
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentResponseVariant2ChecksDeploymentAliasState
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
    public static class CreateDeploymentResponseVariant2ChecksDeploymentAliasStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ChecksDeploymentAliasState value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ChecksDeploymentAliasState.Failed => "failed",
                CreateDeploymentResponseVariant2ChecksDeploymentAliasState.Pending => "pending",
                CreateDeploymentResponseVariant2ChecksDeploymentAliasState.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ChecksDeploymentAliasState? ToEnum(string value)
        {
            return value switch
            {
                "failed" => CreateDeploymentResponseVariant2ChecksDeploymentAliasState.Failed,
                "pending" => CreateDeploymentResponseVariant2ChecksDeploymentAliasState.Pending,
                "succeeded" => CreateDeploymentResponseVariant2ChecksDeploymentAliasState.Succeeded,
                _ => null,
            };
        }
    }
}