
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant1SourceVariant3Provider
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
    public static class CreateDeploymentCheckRunResponseVariant1SourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant1SourceVariant3Provider value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Bitbucket => "bitbucket",
                CreateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Github => "github",
                CreateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant1SourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Bitbucket,
                "github" => CreateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Github,
                "gitlab" => CreateDeploymentCheckRunResponseVariant1SourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}