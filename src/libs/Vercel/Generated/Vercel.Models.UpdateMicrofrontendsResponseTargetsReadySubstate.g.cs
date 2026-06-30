
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseTargetsReadySubstate
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
    public static class UpdateMicrofrontendsResponseTargetsReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTargetsReadySubstate value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTargetsReadySubstate.Promoted => "PROMOTED",
                UpdateMicrofrontendsResponseTargetsReadySubstate.Rolling => "ROLLING",
                UpdateMicrofrontendsResponseTargetsReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTargetsReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => UpdateMicrofrontendsResponseTargetsReadySubstate.Promoted,
                "ROLLING" => UpdateMicrofrontendsResponseTargetsReadySubstate.Rolling,
                "STAGED" => UpdateMicrofrontendsResponseTargetsReadySubstate.Staged,
                _ => null,
            };
        }
    }
}