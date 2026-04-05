
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1GitSourceVariant16Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1GitSourceVariant16TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1GitSourceVariant16Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1GitSourceVariant16Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1GitSourceVariant16Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetDeploymentResponseVariant1GitSourceVariant16Type.Bitbucket,
                _ => null,
            };
        }
    }
}