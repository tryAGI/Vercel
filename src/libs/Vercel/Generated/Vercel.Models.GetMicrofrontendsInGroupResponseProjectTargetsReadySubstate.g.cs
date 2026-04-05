
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTargetsReadySubstate
    {
        /// <summary>
        /// 
        /// </summary>
        Promoted,
        /// <summary>
        /// 
        /// </summary>
        Rolling,
        /// <summary>
        /// 
        /// </summary>
        Staged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectTargetsReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTargetsReadySubstate value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTargetsReadySubstate.Promoted => "PROMOTED",
                GetMicrofrontendsInGroupResponseProjectTargetsReadySubstate.Rolling => "ROLLING",
                GetMicrofrontendsInGroupResponseProjectTargetsReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTargetsReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetMicrofrontendsInGroupResponseProjectTargetsReadySubstate.Promoted,
                "ROLLING" => GetMicrofrontendsInGroupResponseProjectTargetsReadySubstate.Rolling,
                "STAGED" => GetMicrofrontendsInGroupResponseProjectTargetsReadySubstate.Staged,
                _ => null,
            };
        }
    }
}