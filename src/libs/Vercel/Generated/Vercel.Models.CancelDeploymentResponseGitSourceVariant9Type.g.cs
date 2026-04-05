
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitSourceVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseGitSourceVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitSourceVariant9Type value)
        {
            return value switch
            {
                CancelDeploymentResponseGitSourceVariant9Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitSourceVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CancelDeploymentResponseGitSourceVariant9Type.Bitbucket,
                _ => null,
            };
        }
    }
}