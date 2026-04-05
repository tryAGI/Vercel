
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant1SamplingItemEnv
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainResponseVariant1SamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant1SamplingItemEnv value)
        {
            return value switch
            {
                CreateDrainResponseVariant1SamplingItemEnv.Preview => "preview",
                CreateDrainResponseVariant1SamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant1SamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateDrainResponseVariant1SamplingItemEnv.Preview,
                "production" => CreateDrainResponseVariant1SamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}