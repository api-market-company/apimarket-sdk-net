// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral
{
    #pragma warning disable CS1591
    public class HistorialLaboralPostResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The codigoValidacion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CodigoValidacion { get; set; }
#nullable restore
#else
        public string CodigoValidacion { get; set; }
#endif
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse_data? Data { get; set; }
#nullable restore
#else
        public KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse_data Data { get; set; }
#endif
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The status property</summary>
        public int? Status { get; set; }
        /// <summary>The success property</summary>
        public bool? Success { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse"/> and sets the default values.
        /// </summary>
        public HistorialLaboralPostResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "codigoValidacion", n => { CodigoValidacion = n.GetStringValue(); } },
                { "data", n => { Data = n.GetObjectValue<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse_data>(KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse_data.CreateFromDiscriminatorValue); } },
                { "message", n => { Message = n.GetStringValue(); } },
                { "status", n => { Status = n.GetIntValue(); } },
                { "success", n => { Success = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("codigoValidacion", CodigoValidacion);
            writer.WriteObjectValue<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse_data>("data", Data);
            writer.WriteStringValue("message", Message);
            writer.WriteIntValue("status", Status);
            writer.WriteBoolValue("success", Success);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
