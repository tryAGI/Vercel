
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2GitSourceVariant16Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2GitSourceVariant16TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2GitSourceVariant16Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2GitSourceVariant16Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2GitSourceVariant16Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateDeploymentResponseVariant2GitSourceVariant16Type.Bitbucket,
                _ => null,
            };
        }
    }
}