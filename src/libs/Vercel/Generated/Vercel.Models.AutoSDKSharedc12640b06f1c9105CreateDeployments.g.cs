
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the Vercel bot should automatically create GitHub deployments https://docs.github.com/en/rest/deployments/deployments#about-deployments NOTE: repository-dispatch events should be used instead
    /// </summary>
    public enum AutoSDKSharedc12640b06f1c9105CreateDeployments
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
    public static class AutoSDKSharedc12640b06f1c9105CreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc12640b06f1c9105CreateDeployments value)
        {
            return value switch
            {
                AutoSDKSharedc12640b06f1c9105CreateDeployments.Disabled => "disabled",
                AutoSDKSharedc12640b06f1c9105CreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc12640b06f1c9105CreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKSharedc12640b06f1c9105CreateDeployments.Disabled,
                "enabled" => AutoSDKSharedc12640b06f1c9105CreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}