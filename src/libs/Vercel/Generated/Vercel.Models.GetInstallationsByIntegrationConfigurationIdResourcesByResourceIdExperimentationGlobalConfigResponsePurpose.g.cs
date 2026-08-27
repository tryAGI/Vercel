
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose
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
    public static class GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose value)
        {
            return value switch
            {
                GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose.Experimentation => "experimentation",
                GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose.Flags => "flags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose? ToEnum(string value)
        {
            return value switch
            {
                "experimentation" => GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose.Experimentation,
                "flags" => GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose.Flags,
                _ => null,
            };
        }
    }
}