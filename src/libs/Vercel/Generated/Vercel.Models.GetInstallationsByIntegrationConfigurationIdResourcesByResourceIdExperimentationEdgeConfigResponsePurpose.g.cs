
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        Experimentation,
        /// <summary>
        /// 
        /// </summary>
        Flags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose value)
        {
            return value switch
            {
                GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Experimentation => "experimentation",
                GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Flags => "flags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose? ToEnum(string value)
        {
            return value switch
            {
                "experimentation" => GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Experimentation,
                "flags" => GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Flags,
                _ => null,
            };
        }
    }
}