
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2GitSourceVariant12Type
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2GitSourceVariant12TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2GitSourceVariant12Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2GitSourceVariant12Type.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2GitSourceVariant12Type? ToEnum(string value)
        {
            return value switch
            {
                "github" => GetDeploymentResponseVariant2GitSourceVariant12Type.Github,
                _ => null,
            };
        }
    }
}