// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Models
{
    #pragma warning disable CS1591
    public class HistorialData : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The curpOriginal property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurpOriginal { get; set; }
#nullable restore
#else
        public string CurpOriginal { get; set; }
#endif
        /// <summary>The descripcionCurp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DescripcionCurp { get; set; }
#nullable restore
#else
        public string DescripcionCurp { get; set; }
#endif
        /// <summary>The desEstatusCURP property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DesEstatusCURP { get; set; }
#nullable restore
#else
        public string DesEstatusCURP { get; set; }
#endif
        /// <summary>The estatusCurp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EstatusCurp { get; set; }
#nullable restore
#else
        public string EstatusCurp { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Models.HistorialData"/> and sets the default values.
        /// </summary>
        public HistorialData()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Models.HistorialData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Models.HistorialData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Models.HistorialData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "curpOriginal", n => { CurpOriginal = n.GetStringValue(); } },
                { "desEstatusCURP", n => { DesEstatusCURP = n.GetStringValue(); } },
                { "descripcionCurp", n => { DescripcionCurp = n.GetStringValue(); } },
                { "estatusCurp", n => { EstatusCurp = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("curpOriginal", CurpOriginal);
            writer.WriteStringValue("descripcionCurp", DescripcionCurp);
            writer.WriteStringValue("desEstatusCURP", DesEstatusCURP);
            writer.WriteStringValue("estatusCurp", EstatusCurp);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
