
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemAction
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
    public static class GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial => "add-deployment-interstitial",
                GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemAction.AddProjectInterstitial => "add-project-interstitial",
                GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial => "remove-deployment-interstitial",
                GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial => "remove-project-interstitial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "add-deployment-interstitial" => GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial,
                "add-project-interstitial" => GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemAction.AddProjectInterstitial,
                "remove-deployment-interstitial" => GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial,
                "remove-project-interstitial" => GetMicrofrontendsInGroupResponseProjectAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial,
                _ => null,
            };
        }
    }
}