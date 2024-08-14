// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Api.Infonavit.Grupo.BuscarCredito
{
    #pragma warning disable CS1591
    public class BuscarCredito401Error : ApiException, IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Código de validación único para la solicitud</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CodigoValidacion { get; set; }
#nullable restore
#else
        public string CodigoValidacion { get; set; }
#endif
        /// <summary>Mensaje que indica el problema con el token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageEscaped { get; set; }
#nullable restore
#else
        public string MessageEscaped { get; set; }
#endif
        /// <summary>Código de estado HTTP</summary>
        public int? Status { get; set; }
        /// <summary>Indica si la solicitud fue exitosa</summary>
        public bool? Success { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Infonavit.Grupo.BuscarCredito.BuscarCredito401Error"/> and sets the default values.
        /// </summary>
        public BuscarCredito401Error()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Infonavit.Grupo.BuscarCredito.BuscarCredito401Error"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Api.Infonavit.Grupo.BuscarCredito.BuscarCredito401Error CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Api.Infonavit.Grupo.BuscarCredito.BuscarCredito401Error();
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
                { "message", n => { MessageEscaped = n.GetStringValue(); } },
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
            writer.WriteStringValue("message", MessageEscaped);
            writer.WriteIntValue("status", Status);
            writer.WriteBoolValue("success", Success);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
