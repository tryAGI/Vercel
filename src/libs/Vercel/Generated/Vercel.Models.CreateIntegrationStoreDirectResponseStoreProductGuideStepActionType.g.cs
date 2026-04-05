
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductGuideStepActionType
    {
        /// <summary>
        /// 
        /// </summary>
        AddDrain,
        /// <summary>
        /// 
        /// </summary>
        ConfigureProjectConnections,
        /// <summary>
        /// 
        /// </summary>
        ConnectToProject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreProductGuideStepActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductGuideStepActionType value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductGuideStepActionType.AddDrain => "add_drain",
                CreateIntegrationStoreDirectResponseStoreProductGuideStepActionType.ConfigureProjectConnections => "configure_project_connections",
                CreateIntegrationStoreDirectResponseStoreProductGuideStepActionType.ConnectToProject => "connect_to_project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductGuideStepActionType? ToEnum(string value)
        {
            return value switch
            {
                "add_drain" => CreateIntegrationStoreDirectResponseStoreProductGuideStepActionType.AddDrain,
                "configure_project_connections" => CreateIntegrationStoreDirectResponseStoreProductGuideStepActionType.ConfigureProjectConnections,
                "connect_to_project" => CreateIntegrationStoreDirectResponseStoreProductGuideStepActionType.ConnectToProject,
                _ => null,
            };
        }
    }
}