
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant1SamplingItemEnv
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
    public static class GetDrainResponseVariant1SamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant1SamplingItemEnv value)
        {
            return value switch
            {
                GetDrainResponseVariant1SamplingItemEnv.Preview => "preview",
                GetDrainResponseVariant1SamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant1SamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetDrainResponseVariant1SamplingItemEnv.Preview,
                "production" => GetDrainResponseVariant1SamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}