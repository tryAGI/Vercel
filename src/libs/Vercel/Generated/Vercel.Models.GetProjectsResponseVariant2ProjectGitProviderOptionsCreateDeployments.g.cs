
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the Vercel bot should automatically create GitHub deployments https://docs.github.com/en/rest/deployments/deployments#about-deployments NOTE: repository-dispatch events should be used instead
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectGitProviderOptionsCreateDeployments
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
    public static class GetProjectsResponseVariant2ProjectGitProviderOptionsCreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectGitProviderOptionsCreateDeployments value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectGitProviderOptionsCreateDeployments.Disabled => "disabled",
                GetProjectsResponseVariant2ProjectGitProviderOptionsCreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectGitProviderOptionsCreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetProjectsResponseVariant2ProjectGitProviderOptionsCreateDeployments.Disabled,
                "enabled" => GetProjectsResponseVariant2ProjectGitProviderOptionsCreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}