
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin
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
    public static class UserEventPayloadVariant122NewOwnerTeamJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Dsync => "dsync",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Feedback => "feedback",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Github => "github",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Import => "import",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Link => "link",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Mail => "mail",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.OrganizationTeams => "organization-teams",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Saml => "saml",
                UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Bitbucket,
                "dsync" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Dsync,
                "feedback" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Feedback,
                "github" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Github,
                "gitlab" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Gitlab,
                "import" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Import,
                "link" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Link,
                "mail" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbRedeployAttributionCard,
                "nsnb-request-access" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.OrganizationTeams,
                "saml" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Saml,
                "teams" => UserEventPayloadVariant122NewOwnerTeamJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}