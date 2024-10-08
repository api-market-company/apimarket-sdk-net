// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Api.Sat.Grupo.ObtenerDatos
{
    #pragma warning disable CS1591
    public class ObtenerDatosPostResponse_codigosPostales : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The clave property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Clave { get; set; }
#nullable restore
#else
        public string Clave { get; set; }
#endif
        /// <summary>The esMatriz property</summary>
        public bool? EsMatriz { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Sat.Grupo.ObtenerDatos.ObtenerDatosPostResponse_codigosPostales"/> and sets the default values.
        /// </summary>
        public ObtenerDatosPostResponse_codigosPostales()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Sat.Grupo.ObtenerDatos.ObtenerDatosPostResponse_codigosPostales"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Api.Sat.Grupo.ObtenerDatos.ObtenerDatosPostResponse_codigosPostales CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Api.Sat.Grupo.ObtenerDatos.ObtenerDatosPostResponse_codigosPostales();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "clave", n => { Clave = n.GetStringValue(); } },
                { "esMatriz", n => { EsMatriz = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clave", Clave);
            writer.WriteBoolValue("esMatriz", EsMatriz);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
