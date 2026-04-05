
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseSourceVariant3Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeploymentCheckRunResponseSourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseSourceVariant3Provider value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseSourceVariant3Provider.Bitbucket => "bitbucket",
                UpdateDeploymentCheckRunResponseSourceVariant3Provider.Github => "github",
                UpdateDeploymentCheckRunResponseSourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseSourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateDeploymentCheckRunResponseSourceVariant3Provider.Bitbucket,
                "github" => UpdateDeploymentCheckRunResponseSourceVariant3Provider.Github,
                "gitlab" => UpdateDeploymentCheckRunResponseSourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}