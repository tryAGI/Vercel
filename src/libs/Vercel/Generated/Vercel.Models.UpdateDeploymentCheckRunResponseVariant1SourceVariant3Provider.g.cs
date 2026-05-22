
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseVariant1SourceVariant3Provider
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
    public static class UpdateDeploymentCheckRunResponseVariant1SourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseVariant1SourceVariant3Provider value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Bitbucket => "bitbucket",
                UpdateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Github => "github",
                UpdateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseVariant1SourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Bitbucket,
                "github" => UpdateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Github,
                "gitlab" => UpdateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}