
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemAction
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
    public static class UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemAction value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial => "add-deployment-interstitial",
                UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemAction.AddProjectInterstitial => "add-project-interstitial",
                UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial => "remove-deployment-interstitial",
                UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial => "remove-project-interstitial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "add-deployment-interstitial" => UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial,
                "add-project-interstitial" => UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemAction.AddProjectInterstitial,
                "remove-deployment-interstitial" => UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial,
                "remove-project-interstitial" => UpdateMicrofrontendsResponseAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial,
                _ => null,
            };
        }
    }
}