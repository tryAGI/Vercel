
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2GitSourceVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2GitSourceVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2GitSourceVariant7Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2GitSourceVariant7Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2GitSourceVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => CreateDeploymentResponseVariant2GitSourceVariant7Type.Gitlab,
                _ => null,
            };
        }
    }
}