
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the Vercel bot should automatically create GitHub deployments https://docs.github.com/en/rest/deployments/deployments#about-deployments NOTE: repository-dispatch events should be used instead
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectGitProviderOptionsCreateDeployments
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
    public static class GetProjectsResponseVariant3ProjectGitProviderOptionsCreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectGitProviderOptionsCreateDeployments value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectGitProviderOptionsCreateDeployments.Disabled => "disabled",
                GetProjectsResponseVariant3ProjectGitProviderOptionsCreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectGitProviderOptionsCreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetProjectsResponseVariant3ProjectGitProviderOptionsCreateDeployments.Disabled,
                "enabled" => GetProjectsResponseVariant3ProjectGitProviderOptionsCreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}