
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentRequestGitSourceVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentRequestGitSourceVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentRequestGitSourceVariant8Type value)
        {
            return value switch
            {
                CreateDeploymentRequestGitSourceVariant8Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentRequestGitSourceVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateDeploymentRequestGitSourceVariant8Type.Bitbucket,
                _ => null,
            };
        }
    }
}