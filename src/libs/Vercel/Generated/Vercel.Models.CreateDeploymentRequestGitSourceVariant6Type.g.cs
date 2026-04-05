
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentRequestGitSourceVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentRequestGitSourceVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentRequestGitSourceVariant6Type value)
        {
            return value switch
            {
                CreateDeploymentRequestGitSourceVariant6Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentRequestGitSourceVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => CreateDeploymentRequestGitSourceVariant6Type.Gitlab,
                _ => null,
            };
        }
    }
}