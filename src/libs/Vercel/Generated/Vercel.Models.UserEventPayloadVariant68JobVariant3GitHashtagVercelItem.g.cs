
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Since February 2022 All the hashtag-vercel tags found in the commit message triggering the deploy. For example, #VERCEL_DO_SOMETHING
    /// </summary>
    public enum UserEventPayloadVariant68JobVariant3GitHashtagVercelItem
    {
        /// <summary>
        /// 
        /// </summary>
        x_vercelBuildPrio1,
        /// <summary>
        /// 
        /// </summary>
        x_vercelBuildPrio10,
        /// <summary>
        /// 
        /// </summary>
        x_vercelBuildPrio2,
        /// <summary>
        /// 
        /// </summary>
        x_vercelBuildPrio3,
        /// <summary>
        /// 
        /// </summary>
        x_vercelBuildPrio4,
        /// <summary>
        /// 
        /// </summary>
        x_vercelBuildPrio5,
        /// <summary>
        /// 
        /// </summary>
        x_vercelBuildPrio6,
        /// <summary>
        /// 
        /// </summary>
        x_vercelBuildPrio7,
        /// <summary>
        /// 
        /// </summary>
        x_vercelBuildPrio8,
        /// <summary>
        /// 
        /// </summary>
        x_vercelBuildPrio9,
        /// <summary>
        /// 
        /// </summary>
        x_vercelSddjAfterGetRepoForceCancel,
        /// <summary>
        /// 
        /// </summary>
        x_vercelSddjAfterGetRepoForceError,
        /// <summary>
        /// 
        /// </summary>
        x_vercelSddjAfterVerifyForceCancel,
        /// <summary>
        /// 
        /// </summary>
        x_vercelSddjAfterVerifyForceError,
        /// <summary>
        /// 
        /// </summary>
        x_vercelSddjBeforeBuildJobQueuedError,
        /// <summary>
        /// 
        /// </summary>
        x_vercelSddjForceGitForkError,
        /// <summary>
        /// 
        /// </summary>
        x_vercelSkip,
        /// <summary>
        /// 
        /// </summary>
        x_vercelV0Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant68JobVariant3GitHashtagVercelItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant68JobVariant3GitHashtagVercelItem value)
        {
            return value switch
            {
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio1 => "#VERCEL_BUILD_PRIO_1",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio10 => "#VERCEL_BUILD_PRIO_10",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio2 => "#VERCEL_BUILD_PRIO_2",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio3 => "#VERCEL_BUILD_PRIO_3",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio4 => "#VERCEL_BUILD_PRIO_4",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio5 => "#VERCEL_BUILD_PRIO_5",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio6 => "#VERCEL_BUILD_PRIO_6",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio7 => "#VERCEL_BUILD_PRIO_7",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio8 => "#VERCEL_BUILD_PRIO_8",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio9 => "#VERCEL_BUILD_PRIO_9",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjAfterGetRepoForceCancel => "#VERCEL_SDDJ_AFTER_GET_REPO_FORCE_CANCEL",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjAfterGetRepoForceError => "#VERCEL_SDDJ_AFTER_GET_REPO_FORCE_ERROR",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjAfterVerifyForceCancel => "#VERCEL_SDDJ_AFTER_VERIFY_FORCE_CANCEL",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjAfterVerifyForceError => "#VERCEL_SDDJ_AFTER_VERIFY_FORCE_ERROR",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjBeforeBuildJobQueuedError => "#VERCEL_SDDJ_BEFORE_BUILD_JOB_QUEUED_ERROR",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjForceGitForkError => "#VERCEL_SDDJ_FORCE_GIT_FORK_ERROR",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSkip => "#VERCEL_SKIP",
                UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelV0Message => "#VERCEL_V0_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant68JobVariant3GitHashtagVercelItem? ToEnum(string value)
        {
            return value switch
            {
                "#VERCEL_BUILD_PRIO_1" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio1,
                "#VERCEL_BUILD_PRIO_10" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio10,
                "#VERCEL_BUILD_PRIO_2" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio2,
                "#VERCEL_BUILD_PRIO_3" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio3,
                "#VERCEL_BUILD_PRIO_4" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio4,
                "#VERCEL_BUILD_PRIO_5" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio5,
                "#VERCEL_BUILD_PRIO_6" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio6,
                "#VERCEL_BUILD_PRIO_7" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio7,
                "#VERCEL_BUILD_PRIO_8" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio8,
                "#VERCEL_BUILD_PRIO_9" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelBuildPrio9,
                "#VERCEL_SDDJ_AFTER_GET_REPO_FORCE_CANCEL" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjAfterGetRepoForceCancel,
                "#VERCEL_SDDJ_AFTER_GET_REPO_FORCE_ERROR" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjAfterGetRepoForceError,
                "#VERCEL_SDDJ_AFTER_VERIFY_FORCE_CANCEL" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjAfterVerifyForceCancel,
                "#VERCEL_SDDJ_AFTER_VERIFY_FORCE_ERROR" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjAfterVerifyForceError,
                "#VERCEL_SDDJ_BEFORE_BUILD_JOB_QUEUED_ERROR" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjBeforeBuildJobQueuedError,
                "#VERCEL_SDDJ_FORCE_GIT_FORK_ERROR" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSddjForceGitForkError,
                "#VERCEL_SKIP" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelSkip,
                "#VERCEL_V0_MESSAGE" => UserEventPayloadVariant68JobVariant3GitHashtagVercelItem.x_vercelV0Message,
                _ => null,
            };
        }
    }
}