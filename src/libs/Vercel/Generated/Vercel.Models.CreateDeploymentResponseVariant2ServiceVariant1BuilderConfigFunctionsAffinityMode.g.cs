
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinityMode
    {
        /// <summary>
        ///
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinityMode value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinityMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinityMode? ToEnum(string value)
        {
            return value switch
            {
                "strict" => CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinityMode.Strict,
                _ => null,
            };
        }
    }
}