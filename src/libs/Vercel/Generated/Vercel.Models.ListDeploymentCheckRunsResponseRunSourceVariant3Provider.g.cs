
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunSourceVariant3Provider
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
    public static class ListDeploymentCheckRunsResponseRunSourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunSourceVariant3Provider value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunSourceVariant3Provider.Bitbucket => "bitbucket",
                ListDeploymentCheckRunsResponseRunSourceVariant3Provider.Github => "github",
                ListDeploymentCheckRunsResponseRunSourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunSourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => ListDeploymentCheckRunsResponseRunSourceVariant3Provider.Bitbucket,
                "github" => ListDeploymentCheckRunsResponseRunSourceVariant3Provider.Github,
                "gitlab" => ListDeploymentCheckRunsResponseRunSourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}