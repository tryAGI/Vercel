
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseSourceVariant3Provider
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
    public static class CreateDeploymentCheckRunResponseSourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseSourceVariant3Provider value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseSourceVariant3Provider.Bitbucket => "bitbucket",
                CreateDeploymentCheckRunResponseSourceVariant3Provider.Github => "github",
                CreateDeploymentCheckRunResponseSourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseSourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateDeploymentCheckRunResponseSourceVariant3Provider.Bitbucket,
                "github" => CreateDeploymentCheckRunResponseSourceVariant3Provider.Github,
                "gitlab" => CreateDeploymentCheckRunResponseSourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}