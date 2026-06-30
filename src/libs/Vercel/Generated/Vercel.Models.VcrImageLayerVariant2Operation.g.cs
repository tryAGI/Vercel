
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Docker/OCI build instruction associated with an image layer.
    /// </summary>
    public enum VcrImageLayerVariant2Operation
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
        Env,
        /// <summary>
        /// 
        /// </summary>
        Expose,
        /// <summary>
        /// 
        /// </summary>
        From,
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
        Run,
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
    public static class VcrImageLayerVariant2OperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageLayerVariant2Operation value)
        {
            return value switch
            {
                VcrImageLayerVariant2Operation.Add => "ADD",
                VcrImageLayerVariant2Operation.Arg => "ARG",
                VcrImageLayerVariant2Operation.Cmd => "CMD",
                VcrImageLayerVariant2Operation.Copy => "COPY",
                VcrImageLayerVariant2Operation.Entrypoint => "ENTRYPOINT",
                VcrImageLayerVariant2Operation.Env => "ENV",
                VcrImageLayerVariant2Operation.Expose => "EXPOSE",
                VcrImageLayerVariant2Operation.From => "FROM",
                VcrImageLayerVariant2Operation.Healthcheck => "HEALTHCHECK",
                VcrImageLayerVariant2Operation.Label => "LABEL",
                VcrImageLayerVariant2Operation.Onbuild => "ONBUILD",
                VcrImageLayerVariant2Operation.Run => "RUN",
                VcrImageLayerVariant2Operation.Shell => "SHELL",
                VcrImageLayerVariant2Operation.Stopsignal => "STOPSIGNAL",
                VcrImageLayerVariant2Operation.Unknown => "UNKNOWN",
                VcrImageLayerVariant2Operation.User => "USER",
                VcrImageLayerVariant2Operation.Volume => "VOLUME",
                VcrImageLayerVariant2Operation.Workdir => "WORKDIR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageLayerVariant2Operation? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => VcrImageLayerVariant2Operation.Add,
                "ARG" => VcrImageLayerVariant2Operation.Arg,
                "CMD" => VcrImageLayerVariant2Operation.Cmd,
                "COPY" => VcrImageLayerVariant2Operation.Copy,
                "ENTRYPOINT" => VcrImageLayerVariant2Operation.Entrypoint,
                "ENV" => VcrImageLayerVariant2Operation.Env,
                "EXPOSE" => VcrImageLayerVariant2Operation.Expose,
                "FROM" => VcrImageLayerVariant2Operation.From,
                "HEALTHCHECK" => VcrImageLayerVariant2Operation.Healthcheck,
                "LABEL" => VcrImageLayerVariant2Operation.Label,
                "ONBUILD" => VcrImageLayerVariant2Operation.Onbuild,
                "RUN" => VcrImageLayerVariant2Operation.Run,
                "SHELL" => VcrImageLayerVariant2Operation.Shell,
                "STOPSIGNAL" => VcrImageLayerVariant2Operation.Stopsignal,
                "UNKNOWN" => VcrImageLayerVariant2Operation.Unknown,
                "USER" => VcrImageLayerVariant2Operation.User,
                "VOLUME" => VcrImageLayerVariant2Operation.Volume,
                "WORKDIR" => VcrImageLayerVariant2Operation.Workdir,
                _ => null,
            };
        }
    }
}