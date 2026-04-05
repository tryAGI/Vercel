
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2GitSourceVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2GitSourceVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2GitSourceVariant7Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2GitSourceVariant7Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2GitSourceVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => GetDeploymentResponseVariant2GitSourceVariant7Type.Gitlab,
                _ => null,
            };
        }
    }
}