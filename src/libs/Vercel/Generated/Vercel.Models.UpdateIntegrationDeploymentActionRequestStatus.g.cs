
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateIntegrationDeploymentActionRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateIntegrationDeploymentActionRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateIntegrationDeploymentActionRequestStatus value)
        {
            return value switch
            {
                UpdateIntegrationDeploymentActionRequestStatus.Failed => "failed",
                UpdateIntegrationDeploymentActionRequestStatus.Running => "running",
                UpdateIntegrationDeploymentActionRequestStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateIntegrationDeploymentActionRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => UpdateIntegrationDeploymentActionRequestStatus.Failed,
                "running" => UpdateIntegrationDeploymentActionRequestStatus.Running,
                "succeeded" => UpdateIntegrationDeploymentActionRequestStatus.Succeeded,
                _ => null,
            };
        }
    }
}