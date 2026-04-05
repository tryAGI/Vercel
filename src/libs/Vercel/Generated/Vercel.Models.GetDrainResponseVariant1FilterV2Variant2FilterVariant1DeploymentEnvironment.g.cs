
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment
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
    public static class GetDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment value)
        {
            return value switch
            {
                GetDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment.Preview => "preview",
                GetDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment.Preview,
                "production" => GetDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment.Production,
                _ => null,
            };
        }
    }
}