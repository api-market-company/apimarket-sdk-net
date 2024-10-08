// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral
{
    #pragma warning disable CS1591
    public class HistorialLaboralPostResponse_data_semanasCotizadas : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The semanasCotizadas property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SemanasCotizadas { get; set; }
#nullable restore
#else
        public string SemanasCotizadas { get; set; }
#endif
        /// <summary>The semanasDescontadas property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SemanasDescontadas { get; set; }
#nullable restore
#else
        public string SemanasDescontadas { get; set; }
#endif
        /// <summary>The semanasReintegradas property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SemanasReintegradas { get; set; }
#nullable restore
#else
        public string SemanasReintegradas { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse_data_semanasCotizadas"/> and sets the default values.
        /// </summary>
        public HistorialLaboralPostResponse_data_semanasCotizadas()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse_data_semanasCotizadas"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse_data_semanasCotizadas CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse_data_semanasCotizadas();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "semanasCotizadas", n => { SemanasCotizadas = n.GetStringValue(); } },
                { "semanasDescontadas", n => { SemanasDescontadas = n.GetStringValue(); } },
                { "semanasReintegradas", n => { SemanasReintegradas = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("semanasCotizadas", SemanasCotizadas);
            writer.WriteStringValue("semanasDescontadas", SemanasDescontadas);
            writer.WriteStringValue("semanasReintegradas", SemanasReintegradas);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
