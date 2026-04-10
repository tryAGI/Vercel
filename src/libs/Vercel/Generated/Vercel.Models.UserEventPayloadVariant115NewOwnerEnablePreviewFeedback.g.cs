
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the Vercel Toolbar is enabled for preview deployments.
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerEnablePreviewFeedback
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        DefaultForce,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        OffForce,
        /// <summary>
        /// 
        /// </summary>
        On,
        /// <summary>
        /// 
        /// </summary>
        OnForce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant115NewOwnerEnablePreviewFeedbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerEnablePreviewFeedback value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.Default => "default",
                UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.DefaultForce => "default-force",
                UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.Off => "off",
                UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.OffForce => "off-force",
                UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.On => "on",
                UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerEnablePreviewFeedback? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.Default,
                "default-force" => UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.DefaultForce,
                "off" => UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.Off,
                "off-force" => UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.OffForce,
                "on" => UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.On,
                "on-force" => UserEventPayloadVariant115NewOwnerEnablePreviewFeedback.OnForce,
                _ => null,
            };
        }
    }
}