#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notification.toolkit.fluxcd.io;
/// <summary>Receiver is the Schema for the receivers API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Receiver is deprecated, upgrade to v1")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ReceiverList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Receiver>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ReceiverList";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "receivers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notification.toolkit.fluxcd.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReceiverList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Receiver objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Receiver> Items { get; set; }
}

/// <summary>Kind of the referent</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ReceiverSpecResourcesKindEnum>))]
[global::System.Obsolete("v1beta2 Receiver is deprecated, upgrade to v1")]
public enum V1beta2ReceiverSpecResourcesKindEnum
{
    [EnumMember(Value = "Bucket"), JsonStringEnumMemberName("Bucket")]
    Bucket,
    [EnumMember(Value = "GitRepository"), JsonStringEnumMemberName("GitRepository")]
    GitRepository,
    [EnumMember(Value = "Kustomization"), JsonStringEnumMemberName("Kustomization")]
    Kustomization,
    [EnumMember(Value = "HelmRelease"), JsonStringEnumMemberName("HelmRelease")]
    HelmRelease,
    [EnumMember(Value = "HelmChart"), JsonStringEnumMemberName("HelmChart")]
    HelmChart,
    [EnumMember(Value = "HelmRepository"), JsonStringEnumMemberName("HelmRepository")]
    HelmRepository,
    [EnumMember(Value = "ImageRepository"), JsonStringEnumMemberName("ImageRepository")]
    ImageRepository,
    [EnumMember(Value = "ImagePolicy"), JsonStringEnumMemberName("ImagePolicy")]
    ImagePolicy,
    [EnumMember(Value = "ImageUpdateAutomation"), JsonStringEnumMemberName("ImageUpdateAutomation")]
    ImageUpdateAutomation,
    [EnumMember(Value = "OCIRepository"), JsonStringEnumMemberName("OCIRepository")]
    OCIRepository,
    [EnumMember(Value = "ArtifactGenerator"), JsonStringEnumMemberName("ArtifactGenerator")]
    ArtifactGenerator,
    [EnumMember(Value = "ExternalArtifact"), JsonStringEnumMemberName("ExternalArtifact")]
    ExternalArtifact
}

/// <summary>
/// CrossNamespaceObjectReference contains enough information to let you locate the
/// typed referenced object at cluster level
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Receiver is deprecated, upgrade to v1")]
public partial class V1beta2ReceiverSpecResources
{
    /// <summary>API version of the referent</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent</summary>
    [JsonPropertyName("kind")]
    public required V1beta2ReceiverSpecResourcesKindEnum Kind { get; set; }

    /// <summary>
    /// MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// MatchLabels requires the name to be set to `*`.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>
    /// Name of the referent
    /// If multiple resources are targeted `*` may be set.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referent</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// SecretRef specifies the Secret containing the token used
/// to validate the payload authenticity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Receiver is deprecated, upgrade to v1")]
public partial class V1beta2ReceiverSpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Type of webhook sender, used to determine
/// the validation procedure and payload deserialization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ReceiverSpecTypeEnum>))]
[global::System.Obsolete("v1beta2 Receiver is deprecated, upgrade to v1")]
public enum V1beta2ReceiverSpecTypeEnum
{
    [EnumMember(Value = "generic"), JsonStringEnumMemberName("generic")]
    Generic,
    [EnumMember(Value = "generic-hmac"), JsonStringEnumMemberName("generic-hmac")]
    GenericHmac,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github,
    [EnumMember(Value = "gitlab"), JsonStringEnumMemberName("gitlab")]
    Gitlab,
    [EnumMember(Value = "bitbucket"), JsonStringEnumMemberName("bitbucket")]
    Bitbucket,
    [EnumMember(Value = "harbor"), JsonStringEnumMemberName("harbor")]
    Harbor,
    [EnumMember(Value = "dockerhub"), JsonStringEnumMemberName("dockerhub")]
    Dockerhub,
    [EnumMember(Value = "quay"), JsonStringEnumMemberName("quay")]
    Quay,
    [EnumMember(Value = "gcr"), JsonStringEnumMemberName("gcr")]
    Gcr,
    [EnumMember(Value = "nexus"), JsonStringEnumMemberName("nexus")]
    Nexus,
    [EnumMember(Value = "acr"), JsonStringEnumMemberName("acr")]
    Acr
}

/// <summary>ReceiverSpec defines the desired state of the Receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Receiver is deprecated, upgrade to v1")]
public partial class V1beta2ReceiverSpec
{
    /// <summary>
    /// Events specifies the list of event types to handle,
    /// e.g. &apos;push&apos; for GitHub or &apos;Push Hook&apos; for GitLab.
    /// </summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Interval at which to reconcile the Receiver with its Secret references.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>A list of resources to be notified about changes.</summary>
    [JsonPropertyName("resources")]
    public required IList<V1beta2ReceiverSpecResources> Resources { get; set; }

    /// <summary>
    /// SecretRef specifies the Secret containing the token used
    /// to validate the payload authenticity.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1beta2ReceiverSpecSecretRef SecretRef { get; set; }

    /// <summary>
    /// Suspend tells the controller to suspend subsequent
    /// events handling for this receiver.
    /// </summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>
    /// Type of webhook sender, used to determine
    /// the validation procedure and payload deserialization.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1beta2ReceiverSpecTypeEnum Type { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ReceiverStatusConditionsStatusEnum>))]
[global::System.Obsolete("v1beta2 Receiver is deprecated, upgrade to v1")]
public enum V1beta2ReceiverStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Receiver is deprecated, upgrade to v1")]
public partial class V1beta2ReceiverStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1beta2ReceiverStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ReceiverStatus defines the observed state of the Receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Receiver is deprecated, upgrade to v1")]
public partial class V1beta2ReceiverStatus
{
    /// <summary>Conditions holds the conditions for the Receiver.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ReceiverStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>ObservedGeneration is the last observed generation of the Receiver object.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// URL is the generated incoming webhook address in the format
    /// of &apos;/hook/sha256sum(token+name+namespace)&apos;.
    /// Deprecated: Replaced by WebhookPath.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// WebhookPath is the generated incoming webhook address in the format
    /// of &apos;/hook/sha256sum(token+name+namespace)&apos;.
    /// </summary>
    [JsonPropertyName("webhookPath")]
    public string? WebhookPath { get; set; }
}

/// <summary>Receiver is the Schema for the receivers API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Receiver is deprecated, upgrade to v1")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Receiver : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ReceiverSpec?>, IStatus<V1beta2ReceiverStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Receiver";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "receivers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notification.toolkit.fluxcd.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Receiver";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReceiverSpec defines the desired state of the Receiver.</summary>
    [JsonPropertyName("spec")]
    public V1beta2ReceiverSpec? Spec { get; set; }

    /// <summary>ReceiverStatus defines the observed state of the Receiver.</summary>
    [JsonPropertyName("status")]
    public V1beta2ReceiverStatus? Status { get; set; }
}