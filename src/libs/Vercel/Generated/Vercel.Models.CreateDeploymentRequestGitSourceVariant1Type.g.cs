
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentRequestGitSourceVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentRequestGitSourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentRequestGitSourceVariant1Type value)
        {
            return value switch
            {
                CreateDeploymentRequestGitSourceVariant1Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentRequestGitSourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => CreateDeploymentRequestGitSourceVariant1Type.Vercel,
                _ => null,
            };
        }
    }
}