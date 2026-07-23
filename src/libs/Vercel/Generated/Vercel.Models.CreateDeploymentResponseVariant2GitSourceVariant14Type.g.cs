
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2GitSourceVariant14Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubLimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2GitSourceVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2GitSourceVariant14Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2GitSourceVariant14Type.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2GitSourceVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "github-limited" => CreateDeploymentResponseVariant2GitSourceVariant14Type.GithubLimited,
                _ => null,
            };
        }
    }
}