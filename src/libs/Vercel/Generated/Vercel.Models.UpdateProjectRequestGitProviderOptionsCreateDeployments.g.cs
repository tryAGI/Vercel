
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether or not Vercel should automatically create GitHub deployments
    /// </summary>
    public enum UpdateProjectRequestGitProviderOptionsCreateDeployments
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestGitProviderOptionsCreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestGitProviderOptionsCreateDeployments value)
        {
            return value switch
            {
                UpdateProjectRequestGitProviderOptionsCreateDeployments.Disabled => "disabled",
                UpdateProjectRequestGitProviderOptionsCreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestGitProviderOptionsCreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UpdateProjectRequestGitProviderOptionsCreateDeployments.Disabled,
                "enabled" => UpdateProjectRequestGitProviderOptionsCreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}