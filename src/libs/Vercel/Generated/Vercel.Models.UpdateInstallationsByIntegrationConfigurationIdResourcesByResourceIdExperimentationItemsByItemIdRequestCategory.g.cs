
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        Flag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory value)
        {
            return value switch
            {
                UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory.Experiment => "experiment",
                UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory.Flag => "flag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory.Experiment,
                "flag" => UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory.Flag,
                _ => null,
            };
        }
    }
}