
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcrImageLayerVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Arg,
        /// <summary>
        /// 
        /// </summary>
        Cmd,
        /// <summary>
        /// 
        /// </summary>
        Copy,
        /// <summary>
        /// 
        /// </summary>
        Entrypoint,
        /// <summary>
        /// 
        /// </summary>
        Expose,
        /// <summary>
        /// 
        /// </summary>
        Healthcheck,
        /// <summary>
        /// 
        /// </summary>
        Label,
        /// <summary>
        /// 
        /// </summary>
        Onbuild,
        /// <summary>
        /// 
        /// </summary>
        Shell,
        /// <summary>
        /// 
        /// </summary>
        Stopsignal,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Volume,
        /// <summary>
        /// 
        /// </summary>
        Workdir,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VcrImageLayerVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageLayerVariant4Type value)
        {
            return value switch
            {
                VcrImageLayerVariant4Type.Add => "ADD",
                VcrImageLayerVariant4Type.Arg => "ARG",
                VcrImageLayerVariant4Type.Cmd => "CMD",
                VcrImageLayerVariant4Type.Copy => "COPY",
                VcrImageLayerVariant4Type.Entrypoint => "ENTRYPOINT",
                VcrImageLayerVariant4Type.Expose => "EXPOSE",
                VcrImageLayerVariant4Type.Healthcheck => "HEALTHCHECK",
                VcrImageLayerVariant4Type.Label => "LABEL",
                VcrImageLayerVariant4Type.Onbuild => "ONBUILD",
                VcrImageLayerVariant4Type.Shell => "SHELL",
                VcrImageLayerVariant4Type.Stopsignal => "STOPSIGNAL",
                VcrImageLayerVariant4Type.Unknown => "UNKNOWN",
                VcrImageLayerVariant4Type.User => "USER",
                VcrImageLayerVariant4Type.Volume => "VOLUME",
                VcrImageLayerVariant4Type.Workdir => "WORKDIR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageLayerVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => VcrImageLayerVariant4Type.Add,
                "ARG" => VcrImageLayerVariant4Type.Arg,
                "CMD" => VcrImageLayerVariant4Type.Cmd,
                "COPY" => VcrImageLayerVariant4Type.Copy,
                "ENTRYPOINT" => VcrImageLayerVariant4Type.Entrypoint,
                "EXPOSE" => VcrImageLayerVariant4Type.Expose,
                "HEALTHCHECK" => VcrImageLayerVariant4Type.Healthcheck,
                "LABEL" => VcrImageLayerVariant4Type.Label,
                "ONBUILD" => VcrImageLayerVariant4Type.Onbuild,
                "SHELL" => VcrImageLayerVariant4Type.Shell,
                "STOPSIGNAL" => VcrImageLayerVariant4Type.Stopsignal,
                "UNKNOWN" => VcrImageLayerVariant4Type.Unknown,
                "USER" => VcrImageLayerVariant4Type.User,
                "VOLUME" => VcrImageLayerVariant4Type.Volume,
                "WORKDIR" => VcrImageLayerVariant4Type.Workdir,
                _ => null,
            };
        }
    }
}