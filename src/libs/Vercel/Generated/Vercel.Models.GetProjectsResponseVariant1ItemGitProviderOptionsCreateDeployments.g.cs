
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the Vercel bot should automatically create GitHub deployments https://docs.github.com/en/rest/deployments/deployments#about-deployments NOTE: repository-dispatch events should be used instead
    /// </summary>
    public enum GetProjectsResponseVariant1ItemGitProviderOptionsCreateDeployments
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
    public static class GetProjectsResponseVariant1ItemGitProviderOptionsCreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemGitProviderOptionsCreateDeployments value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemGitProviderOptionsCreateDeployments.Disabled => "disabled",
                GetProjectsResponseVariant1ItemGitProviderOptionsCreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemGitProviderOptionsCreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetProjectsResponseVariant1ItemGitProviderOptionsCreateDeployments.Disabled,
                "enabled" => GetProjectsResponseVariant1ItemGitProviderOptionsCreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}