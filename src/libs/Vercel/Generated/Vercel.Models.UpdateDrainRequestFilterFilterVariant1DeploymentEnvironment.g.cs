
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment
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
    public static class UpdateDrainRequestFilterFilterVariant1DeploymentEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment value)
        {
            return value switch
            {
                UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment.Preview => "preview",
                UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment.Preview,
                "production" => UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment.Production,
                _ => null,
            };
        }
    }
}