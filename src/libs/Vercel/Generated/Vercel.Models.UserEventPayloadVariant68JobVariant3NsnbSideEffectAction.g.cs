
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant68JobVariant3NsnbSideEffectAction
    {
        /// <summary>
        /// 
        /// </summary>
        AutoApprovedMember,
        /// <summary>
        /// 
        /// </summary>
        AutoApprovedPendingInvite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant68JobVariant3NsnbSideEffectActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant68JobVariant3NsnbSideEffectAction value)
        {
            return value switch
            {
                UserEventPayloadVariant68JobVariant3NsnbSideEffectAction.AutoApprovedMember => "auto-approved-member",
                UserEventPayloadVariant68JobVariant3NsnbSideEffectAction.AutoApprovedPendingInvite => "auto-approved-pending-invite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant68JobVariant3NsnbSideEffectAction? ToEnum(string value)
        {
            return value switch
            {
                "auto-approved-member" => UserEventPayloadVariant68JobVariant3NsnbSideEffectAction.AutoApprovedMember,
                "auto-approved-pending-invite" => UserEventPayloadVariant68JobVariant3NsnbSideEffectAction.AutoApprovedPendingInvite,
                _ => null,
            };
        }
    }
}