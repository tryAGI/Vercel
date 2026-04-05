
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitSourceVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseGitSourceVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitSourceVariant2Type value)
        {
            return value switch
            {
                CreateDeploymentResponseGitSourceVariant2Type.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitSourceVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "github" => CreateDeploymentResponseGitSourceVariant2Type.Github,
                _ => null,
            };
        }
    }
}