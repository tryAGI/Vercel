
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainRequestFilterFilterVariant1DeploymentEnvironment
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
    public static class CreateDrainRequestFilterFilterVariant1DeploymentEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainRequestFilterFilterVariant1DeploymentEnvironment value)
        {
            return value switch
            {
                CreateDrainRequestFilterFilterVariant1DeploymentEnvironment.Preview => "preview",
                CreateDrainRequestFilterFilterVariant1DeploymentEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainRequestFilterFilterVariant1DeploymentEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateDrainRequestFilterFilterVariant1DeploymentEnvironment.Preview,
                "production" => CreateDrainRequestFilterFilterVariant1DeploymentEnvironment.Production,
                _ => null,
            };
        }
    }
}