
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1GitSourceVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1GitSourceVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1GitSourceVariant7Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1GitSourceVariant7Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1GitSourceVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => GetDeploymentResponseVariant1GitSourceVariant7Type.Gitlab,
                _ => null,
            };
        }
    }
}