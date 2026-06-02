
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseAbuseInterstitialHistoryItemAction
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
    public static class GetProjectResponseAbuseInterstitialHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAbuseInterstitialHistoryItemAction value)
        {
            return value switch
            {
                GetProjectResponseAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial => "add-deployment-interstitial",
                GetProjectResponseAbuseInterstitialHistoryItemAction.AddProjectInterstitial => "add-project-interstitial",
                GetProjectResponseAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial => "remove-deployment-interstitial",
                GetProjectResponseAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial => "remove-project-interstitial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAbuseInterstitialHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "add-deployment-interstitial" => GetProjectResponseAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial,
                "add-project-interstitial" => GetProjectResponseAbuseInterstitialHistoryItemAction.AddProjectInterstitial,
                "remove-deployment-interstitial" => GetProjectResponseAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial,
                "remove-project-interstitial" => GetProjectResponseAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial,
                _ => null,
            };
        }
    }
}