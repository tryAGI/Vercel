
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the Vercel bot should automatically create GitHub deployments https://docs.github.com/en/rest/deployments/deployments#about-deployments NOTE: repository-dispatch events should be used instead
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectGitProviderOptionsCreateDeployments
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
    public static class GetMicrofrontendsInGroupResponseProjectGitProviderOptionsCreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectGitProviderOptionsCreateDeployments value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectGitProviderOptionsCreateDeployments.Disabled => "disabled",
                GetMicrofrontendsInGroupResponseProjectGitProviderOptionsCreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectGitProviderOptionsCreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetMicrofrontendsInGroupResponseProjectGitProviderOptionsCreateDeployments.Disabled,
                "enabled" => GetMicrofrontendsInGroupResponseProjectGitProviderOptionsCreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}