
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant68JobVariant4NsnbSideEffectAction
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
    public static class UserEventPayloadVariant68JobVariant4NsnbSideEffectActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant68JobVariant4NsnbSideEffectAction value)
        {
            return value switch
            {
                UserEventPayloadVariant68JobVariant4NsnbSideEffectAction.AutoApprovedMember => "auto-approved-member",
                UserEventPayloadVariant68JobVariant4NsnbSideEffectAction.AutoApprovedPendingInvite => "auto-approved-pending-invite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant68JobVariant4NsnbSideEffectAction? ToEnum(string value)
        {
            return value switch
            {
                "auto-approved-member" => UserEventPayloadVariant68JobVariant4NsnbSideEffectAction.AutoApprovedMember,
                "auto-approved-pending-invite" => UserEventPayloadVariant68JobVariant4NsnbSideEffectAction.AutoApprovedPendingInvite,
                _ => null,
            };
        }
    }
}