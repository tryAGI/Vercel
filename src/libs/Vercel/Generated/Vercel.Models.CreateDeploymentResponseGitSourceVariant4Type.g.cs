
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitSourceVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubCustomHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseGitSourceVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitSourceVariant4Type value)
        {
            return value switch
            {
                CreateDeploymentResponseGitSourceVariant4Type.GithubCustomHost => "github-custom-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitSourceVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "github-custom-host" => CreateDeploymentResponseGitSourceVariant4Type.GithubCustomHost,
                _ => null,
            };
        }
    }
}