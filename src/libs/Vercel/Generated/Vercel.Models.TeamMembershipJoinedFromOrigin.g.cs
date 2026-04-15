
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamMembershipJoinedFromOrigin
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
    public static class TeamMembershipJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamMembershipJoinedFromOrigin value)
        {
            return value switch
            {
                TeamMembershipJoinedFromOrigin.Bitbucket => "bitbucket",
                TeamMembershipJoinedFromOrigin.Dsync => "dsync",
                TeamMembershipJoinedFromOrigin.Feedback => "feedback",
                TeamMembershipJoinedFromOrigin.Github => "github",
                TeamMembershipJoinedFromOrigin.Gitlab => "gitlab",
                TeamMembershipJoinedFromOrigin.Import => "import",
                TeamMembershipJoinedFromOrigin.Link => "link",
                TeamMembershipJoinedFromOrigin.Mail => "mail",
                TeamMembershipJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                TeamMembershipJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                TeamMembershipJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                TeamMembershipJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                TeamMembershipJoinedFromOrigin.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                TeamMembershipJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                TeamMembershipJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                TeamMembershipJoinedFromOrigin.OrganizationTeams => "organization-teams",
                TeamMembershipJoinedFromOrigin.Saml => "saml",
                TeamMembershipJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamMembershipJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => TeamMembershipJoinedFromOrigin.Bitbucket,
                "dsync" => TeamMembershipJoinedFromOrigin.Dsync,
                "feedback" => TeamMembershipJoinedFromOrigin.Feedback,
                "github" => TeamMembershipJoinedFromOrigin.Github,
                "gitlab" => TeamMembershipJoinedFromOrigin.Gitlab,
                "import" => TeamMembershipJoinedFromOrigin.Import,
                "link" => TeamMembershipJoinedFromOrigin.Link,
                "mail" => TeamMembershipJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => TeamMembershipJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => TeamMembershipJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => TeamMembershipJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => TeamMembershipJoinedFromOrigin.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => TeamMembershipJoinedFromOrigin.NsnbRedeployAttributionCard,
                "nsnb-request-access" => TeamMembershipJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => TeamMembershipJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => TeamMembershipJoinedFromOrigin.OrganizationTeams,
                "saml" => TeamMembershipJoinedFromOrigin.Saml,
                "teams" => TeamMembershipJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}