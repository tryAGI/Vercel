
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant135RemovedUsersJoinedFromOrigin
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
    public static class UserEventPayloadVariant135RemovedUsersJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant135RemovedUsersJoinedFromOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Dsync => "dsync",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Feedback => "feedback",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Github => "github",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Import => "import",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Link => "link",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Mail => "mail",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.OrganizationTeams => "organization-teams",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Saml => "saml",
                UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant135RemovedUsersJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Bitbucket,
                "dsync" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Dsync,
                "feedback" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Feedback,
                "github" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Github,
                "gitlab" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Gitlab,
                "import" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Import,
                "link" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Link,
                "mail" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbRedeploy,
                "nsnb-request-access" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.OrganizationTeams,
                "saml" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Saml,
                "teams" => UserEventPayloadVariant135RemovedUsersJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}