
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment
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
    public static class CreateDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment value)
        {
            return value switch
            {
                CreateDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment.Preview => "preview",
                CreateDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment.Preview,
                "production" => CreateDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment.Production,
                _ => null,
            };
        }
    }
}