
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant1SourceVariant3Provider
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
    public static class GetDeploymentCheckRunResponseVariant1SourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant1SourceVariant3Provider value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant1SourceVariant3Provider.Bitbucket => "bitbucket",
                GetDeploymentCheckRunResponseVariant1SourceVariant3Provider.Github => "github",
                GetDeploymentCheckRunResponseVariant1SourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant1SourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetDeploymentCheckRunResponseVariant1SourceVariant3Provider.Bitbucket,
                "github" => GetDeploymentCheckRunResponseVariant1SourceVariant3Provider.Github,
                "gitlab" => GetDeploymentCheckRunResponseVariant1SourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}