
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemAction
    {
        /// <summary>
        /// 
        /// </summary>
        AddDeploymentInterstitial,
        /// <summary>
        /// 
        /// </summary>
        AddProjectInterstitial,
        /// <summary>
        /// 
        /// </summary>
        RemoveDeploymentInterstitial,
        /// <summary>
        /// 
        /// </summary>
        RemoveProjectInterstitial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial => "add-deployment-interstitial",
                GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemAction.AddProjectInterstitial => "add-project-interstitial",
                GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial => "remove-deployment-interstitial",
                GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial => "remove-project-interstitial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "add-deployment-interstitial" => GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial,
                "add-project-interstitial" => GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemAction.AddProjectInterstitial,
                "remove-deployment-interstitial" => GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial,
                "remove-project-interstitial" => GetProjectsResponseVariant3ProjectAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial,
                _ => null,
            };
        }
    }
}