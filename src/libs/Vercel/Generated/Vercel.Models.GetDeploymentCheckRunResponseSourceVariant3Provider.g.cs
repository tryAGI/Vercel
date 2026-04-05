
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseSourceVariant3Provider
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
    public static class GetDeploymentCheckRunResponseSourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseSourceVariant3Provider value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseSourceVariant3Provider.Bitbucket => "bitbucket",
                GetDeploymentCheckRunResponseSourceVariant3Provider.Github => "github",
                GetDeploymentCheckRunResponseSourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseSourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetDeploymentCheckRunResponseSourceVariant3Provider.Bitbucket,
                "github" => GetDeploymentCheckRunResponseSourceVariant3Provider.Github,
                "gitlab" => GetDeploymentCheckRunResponseSourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}