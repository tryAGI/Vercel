
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason
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
    public static class UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}