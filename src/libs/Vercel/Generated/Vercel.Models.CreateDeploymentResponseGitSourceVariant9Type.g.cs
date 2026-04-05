
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitSourceVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseGitSourceVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitSourceVariant9Type value)
        {
            return value switch
            {
                CreateDeploymentResponseGitSourceVariant9Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitSourceVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateDeploymentResponseGitSourceVariant9Type.Bitbucket,
                _ => null,
            };
        }
    }
}