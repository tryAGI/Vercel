
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the Vercel bot should automatically create GitHub deployments https://docs.github.com/en/rest/deployments/deployments#about-deployments NOTE: repository-dispatch events should be used instead
    /// </summary>
    public enum UpdateMicrofrontendsResponseGitProviderOptionsCreateDeployments
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
    public static class UpdateMicrofrontendsResponseGitProviderOptionsCreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseGitProviderOptionsCreateDeployments value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseGitProviderOptionsCreateDeployments.Disabled => "disabled",
                UpdateMicrofrontendsResponseGitProviderOptionsCreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseGitProviderOptionsCreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UpdateMicrofrontendsResponseGitProviderOptionsCreateDeployments.Disabled,
                "enabled" => UpdateMicrofrontendsResponseGitProviderOptionsCreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}