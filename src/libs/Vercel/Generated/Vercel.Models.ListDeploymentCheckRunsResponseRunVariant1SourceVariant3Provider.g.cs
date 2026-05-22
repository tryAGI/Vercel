
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunVariant1SourceVariant3Provider
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
    public static class ListDeploymentCheckRunsResponseRunVariant1SourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunVariant1SourceVariant3Provider value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunVariant1SourceVariant3Provider.Bitbucket => "bitbucket",
                ListDeploymentCheckRunsResponseRunVariant1SourceVariant3Provider.Github => "github",
                ListDeploymentCheckRunsResponseRunVariant1SourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunVariant1SourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => ListDeploymentCheckRunsResponseRunVariant1SourceVariant3Provider.Bitbucket,
                "github" => ListDeploymentCheckRunsResponseRunVariant1SourceVariant3Provider.Github,
                "gitlab" => ListDeploymentCheckRunsResponseRunVariant1SourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}