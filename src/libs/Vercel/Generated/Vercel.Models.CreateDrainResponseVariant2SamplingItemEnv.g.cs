
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2SamplingItemEnv
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
    public static class CreateDrainResponseVariant2SamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2SamplingItemEnv value)
        {
            return value switch
            {
                CreateDrainResponseVariant2SamplingItemEnv.Preview => "preview",
                CreateDrainResponseVariant2SamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2SamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateDrainResponseVariant2SamplingItemEnv.Preview,
                "production" => CreateDrainResponseVariant2SamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}