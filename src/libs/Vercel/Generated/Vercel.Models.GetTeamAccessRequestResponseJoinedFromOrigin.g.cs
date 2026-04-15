
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTeamAccessRequestResponseJoinedFromOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Dsync,
        /// <summary>
        /// 
        /// </summary>
        Feedback,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
        /// <summary>
        /// 
        /// </summary>
        Import,
        /// <summary>
        /// 
        /// </summary>
        Link,
        /// <summary>
        /// 
        /// </summary>
        Mail,
        /// <summary>
        /// 
        /// </summary>
        NsnbAutoApprove,
        /// <summary>
        /// 
        /// </summary>
        NsnbHobbyUpgrade,
        /// <summary>
        /// 
        /// </summary>
        NsnbInvite,
        /// <summary>
        /// 
        /// </summary>
        NsnbRedeploy,
        /// <summary>
        /// 
        /// </summary>
        NsnbRedeployAttributionCard,
        /// <summary>
        /// 
        /// </summary>
        NsnbRequestAccess,
        /// <summary>
        /// 
        /// </summary>
        NsnbViewerUpgrade,
        /// <summary>
        /// 
        /// </summary>
        OrganizationTeams,
        /// <summary>
        /// 
        /// </summary>
        Saml,
        /// <summary>
        /// 
        /// </summary>
        Teams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTeamAccessRequestResponseJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTeamAccessRequestResponseJoinedFromOrigin value)
        {
            return value switch
            {
                GetTeamAccessRequestResponseJoinedFromOrigin.Bitbucket => "bitbucket",
                GetTeamAccessRequestResponseJoinedFromOrigin.Dsync => "dsync",
                GetTeamAccessRequestResponseJoinedFromOrigin.Feedback => "feedback",
                GetTeamAccessRequestResponseJoinedFromOrigin.Github => "github",
                GetTeamAccessRequestResponseJoinedFromOrigin.Gitlab => "gitlab",
                GetTeamAccessRequestResponseJoinedFromOrigin.Import => "import",
                GetTeamAccessRequestResponseJoinedFromOrigin.Link => "link",
                GetTeamAccessRequestResponseJoinedFromOrigin.Mail => "mail",
                GetTeamAccessRequestResponseJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                GetTeamAccessRequestResponseJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                GetTeamAccessRequestResponseJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                GetTeamAccessRequestResponseJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                GetTeamAccessRequestResponseJoinedFromOrigin.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                GetTeamAccessRequestResponseJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                GetTeamAccessRequestResponseJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                GetTeamAccessRequestResponseJoinedFromOrigin.OrganizationTeams => "organization-teams",
                GetTeamAccessRequestResponseJoinedFromOrigin.Saml => "saml",
                GetTeamAccessRequestResponseJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTeamAccessRequestResponseJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetTeamAccessRequestResponseJoinedFromOrigin.Bitbucket,
                "dsync" => GetTeamAccessRequestResponseJoinedFromOrigin.Dsync,
                "feedback" => GetTeamAccessRequestResponseJoinedFromOrigin.Feedback,
                "github" => GetTeamAccessRequestResponseJoinedFromOrigin.Github,
                "gitlab" => GetTeamAccessRequestResponseJoinedFromOrigin.Gitlab,
                "import" => GetTeamAccessRequestResponseJoinedFromOrigin.Import,
                "link" => GetTeamAccessRequestResponseJoinedFromOrigin.Link,
                "mail" => GetTeamAccessRequestResponseJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => GetTeamAccessRequestResponseJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => GetTeamAccessRequestResponseJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => GetTeamAccessRequestResponseJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => GetTeamAccessRequestResponseJoinedFromOrigin.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => GetTeamAccessRequestResponseJoinedFromOrigin.NsnbRedeployAttributionCard,
                "nsnb-request-access" => GetTeamAccessRequestResponseJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => GetTeamAccessRequestResponseJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => GetTeamAccessRequestResponseJoinedFromOrigin.OrganizationTeams,
                "saml" => GetTeamAccessRequestResponseJoinedFromOrigin.Saml,
                "teams" => GetTeamAccessRequestResponseJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}