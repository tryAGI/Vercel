
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentRequestGitSourceVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentRequestGitSourceVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentRequestGitSourceVariant7Type value)
        {
            return value switch
            {
                CreateDeploymentRequestGitSourceVariant7Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentRequestGitSourceVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateDeploymentRequestGitSourceVariant7Type.Bitbucket,
                _ => null,
            };
        }
    }
}