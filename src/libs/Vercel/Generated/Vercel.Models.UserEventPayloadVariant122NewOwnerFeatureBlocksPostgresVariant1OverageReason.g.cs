
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsUsage,
        /// <summary>
        /// 
        /// </summary>
        Artifacts,
        /// <summary>
        /// 
        /// </summary>
        Bandwidth,
        /// <summary>
        /// 
        /// </summary>
        BlobDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalAdvancedRequests,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalAvgSizeInBytes,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalGetResponseObjectSizeInBytes,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalSimpleRequests,
        /// <summary>
        /// 
        /// </summary>
        ConnectDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        DataCacheRead,
        /// <summary>
        /// 
        /// </summary>
        DataCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigRead,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigWrite,
        /// <summary>
        /// 
        /// </summary>
        EdgeFunctionExecutionUnits,
        /// <summary>
        /// 
        /// </summary>
        EdgeMiddlewareInvocations,
        /// <summary>
        /// 
        /// </summary>
        EdgeRequest,
        /// <summary>
        /// 
        /// </summary>
        EdgeRequestAdditionalCpuDuration,
        /// <summary>
        /// 
        /// </summary>
        ElasticConcurrencyBuildSlots,
        /// <summary>
        /// 
        /// </summary>
        FastDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        FastOriginTransfer,
        /// <summary>
        /// 
        /// </summary>
        FluidCpuDuration,
        /// <summary>
        /// 
        /// </summary>
        FluidDuration,
        /// <summary>
        /// 
        /// </summary>
        FunctionDuration,
        /// <summary>
        /// 
        /// </summary>
        FunctionInvocation,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationCacheRead,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationTransformation,
        /// <summary>
        /// 
        /// </summary>
        LogDrainsVolume,
        /// <summary>
        /// 
        /// </summary>
        MonitoringMetric,
        /// <summary>
        /// 
        /// </summary>
        ObservabilityEvent,
        /// <summary>
        /// 
        /// </summary>
        OnDemandConcurrencyMinutes,
        /// <summary>
        /// 
        /// </summary>
        RuntimeCacheRead,
        /// <summary>
        /// 
        /// </summary>
        RuntimeCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        ServerlessFunctionExecution,
        /// <summary>
        /// 
        /// </summary>
        SourceImages,
        /// <summary>
        /// 
        /// </summary>
        WafOwaspExcessBytes,
        /// <summary>
        /// 
        /// </summary>
        WafOwaspRequests,
        /// <summary>
        /// 
        /// </summary>
        WafRateLimitRequest,
        /// <summary>
        /// 
        /// </summary>
        WebAnalyticsEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant122NewOwnerFeatureBlocksPostgresVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}