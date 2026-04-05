
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1DeploymentEnvironment
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
    public static class GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1DeploymentEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1DeploymentEnvironment value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1DeploymentEnvironment.Preview => "preview",
                GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1DeploymentEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1DeploymentEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1DeploymentEnvironment.Preview,
                "production" => GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1DeploymentEnvironment.Production,
                _ => null,
            };
        }
    }
}