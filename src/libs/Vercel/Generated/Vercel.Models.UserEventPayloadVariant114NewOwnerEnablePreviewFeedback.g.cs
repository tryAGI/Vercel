
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the Vercel Toolbar is enabled for preview deployments.
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerEnablePreviewFeedback
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
    public static class UserEventPayloadVariant114NewOwnerEnablePreviewFeedbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerEnablePreviewFeedback value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.Default => "default",
                UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.DefaultForce => "default-force",
                UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.Off => "off",
                UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.OffForce => "off-force",
                UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.On => "on",
                UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerEnablePreviewFeedback? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.Default,
                "default-force" => UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.DefaultForce,
                "off" => UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.Off,
                "off-force" => UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.OffForce,
                "on" => UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.On,
                "on-force" => UserEventPayloadVariant114NewOwnerEnablePreviewFeedback.OnForce,
                _ => null,
            };
        }
    }
}