
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of entity.<br/>
    /// Example: author
    /// </summary>
    public enum UserEventEntitieType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Author,
        /// <summary>
        /// 
        /// </summary>
        BitbucketLogin,
        /// <summary>
        /// 
        /// </summary>
        Bold,
        /// <summary>
        /// 
        /// </summary>
        DeploymentHost,
        /// <summary>
        /// 
        /// </summary>
        DnsRecord,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfig,
        /// <summary>
        /// 
        /// </summary>
        EnvVarName,
        /// <summary>
        /// 
        /// </summary>
        Flag,
        /// <summary>
        /// 
        /// </summary>
        FlagsSegment,
        /// <summary>
        /// 
        /// </summary>
        FlagsSettings,
        /// <summary>
        /// 
        /// </summary>
        GitLink,
        /// <summary>
        /// 
        /// </summary>
        GithubLogin,
        /// <summary>
        /// 
        /// </summary>
        GitlabLogin,
        /// <summary>
        /// 
        /// </summary>
        HookName,
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        Link,
        /// <summary>
        /// 
        /// </summary>
        ProjectName,
        /// <summary>
        /// 
        /// </summary>
        ScalingRules,
        /// <summary>
        /// 
        /// </summary>
        Store,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Target,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventEntitieTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventEntitieType value)
        {
            return value switch
            {
                UserEventEntitieType.App => "app",
                UserEventEntitieType.Author => "author",
                UserEventEntitieType.BitbucketLogin => "bitbucket_login",
                UserEventEntitieType.Bold => "bold",
                UserEventEntitieType.DeploymentHost => "deployment_host",
                UserEventEntitieType.DnsRecord => "dns_record",
                UserEventEntitieType.EdgeConfig => "edge-config",
                UserEventEntitieType.EnvVarName => "env_var_name",
                UserEventEntitieType.Flag => "flag",
                UserEventEntitieType.FlagsSegment => "flags-segment",
                UserEventEntitieType.FlagsSettings => "flags-settings",
                UserEventEntitieType.GitLink => "git_link",
                UserEventEntitieType.GithubLogin => "github_login",
                UserEventEntitieType.GitlabLogin => "gitlab_login",
                UserEventEntitieType.HookName => "hook_name",
                UserEventEntitieType.Integration => "integration",
                UserEventEntitieType.Link => "link",
                UserEventEntitieType.ProjectName => "project_name",
                UserEventEntitieType.ScalingRules => "scaling_rules",
                UserEventEntitieType.Store => "store",
                UserEventEntitieType.System => "system",
                UserEventEntitieType.Target => "target",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventEntitieType? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventEntitieType.App,
                "author" => UserEventEntitieType.Author,
                "bitbucket_login" => UserEventEntitieType.BitbucketLogin,
                "bold" => UserEventEntitieType.Bold,
                "deployment_host" => UserEventEntitieType.DeploymentHost,
                "dns_record" => UserEventEntitieType.DnsRecord,
                "edge-config" => UserEventEntitieType.EdgeConfig,
                "env_var_name" => UserEventEntitieType.EnvVarName,
                "flag" => UserEventEntitieType.Flag,
                "flags-segment" => UserEventEntitieType.FlagsSegment,
                "flags-settings" => UserEventEntitieType.FlagsSettings,
                "git_link" => UserEventEntitieType.GitLink,
                "github_login" => UserEventEntitieType.GithubLogin,
                "gitlab_login" => UserEventEntitieType.GitlabLogin,
                "hook_name" => UserEventEntitieType.HookName,
                "integration" => UserEventEntitieType.Integration,
                "link" => UserEventEntitieType.Link,
                "project_name" => UserEventEntitieType.ProjectName,
                "scaling_rules" => UserEventEntitieType.ScalingRules,
                "store" => UserEventEntitieType.Store,
                "system" => UserEventEntitieType.System,
                "target" => UserEventEntitieType.Target,
                _ => null,
            };
        }
    }
}