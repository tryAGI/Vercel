
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the Vercel Toolbar is enabled for preview deployments.
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerEnablePreviewFeedback
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
    public static class UserEventPayloadVariant116NewOwnerEnablePreviewFeedbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerEnablePreviewFeedback value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.Default => "default",
                UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.DefaultForce => "default-force",
                UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.Off => "off",
                UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.OffForce => "off-force",
                UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.On => "on",
                UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerEnablePreviewFeedback? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.Default,
                "default-force" => UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.DefaultForce,
                "off" => UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.Off,
                "off-force" => UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.OffForce,
                "on" => UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.On,
                "on-force" => UserEventPayloadVariant116NewOwnerEnablePreviewFeedback.OnForce,
                _ => null,
            };
        }
    }
}