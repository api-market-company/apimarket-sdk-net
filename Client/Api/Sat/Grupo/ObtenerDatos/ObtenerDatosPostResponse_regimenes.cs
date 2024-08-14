// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Api.Sat.Grupo.ObtenerDatos
{
    #pragma warning disable CS1591
    public class ObtenerDatosPostResponse_regimenes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cregimen property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Cregimen { get; set; }
#nullable restore
#else
        public string Cregimen { get; set; }
#endif
        /// <summary>The dregimen property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Dregimen { get; set; }
#nullable restore
#else
        public string Dregimen { get; set; }
#endif
        /// <summary>The faltaReg property</summary>
        public Date? FaltaReg { get; set; }
        /// <summary>The fbajaReg property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FbajaReg { get; set; }
#nullable restore
#else
        public string FbajaReg { get; set; }
#endif
        /// <summary>The fefecAReg property</summary>
        public Date? FefecAReg { get; set; }
        /// <summary>The fefecBReg property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FefecBReg { get; set; }
#nullable restore
#else
        public string FefecBReg { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Sat.Grupo.ObtenerDatos.ObtenerDatosPostResponse_regimenes"/> and sets the default values.
        /// </summary>
        public ObtenerDatosPostResponse_regimenes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Sat.Grupo.ObtenerDatos.ObtenerDatosPostResponse_regimenes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Api.Sat.Grupo.ObtenerDatos.ObtenerDatosPostResponse_regimenes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Api.Sat.Grupo.ObtenerDatos.ObtenerDatosPostResponse_regimenes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cregimen", n => { Cregimen = n.GetStringValue(); } },
                { "dregimen", n => { Dregimen = n.GetStringValue(); } },
                { "faltaReg", n => { FaltaReg = n.GetDateValue(); } },
                { "fbajaReg", n => { FbajaReg = n.GetStringValue(); } },
                { "fefecAReg", n => { FefecAReg = n.GetDateValue(); } },
                { "fefecBReg", n => { FefecBReg = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cregimen", Cregimen);
            writer.WriteStringValue("dregimen", Dregimen);
            writer.WriteDateValue("faltaReg", FaltaReg);
            writer.WriteStringValue("fbajaReg", FbajaReg);
            writer.WriteDateValue("fefecAReg", FefecAReg);
            writer.WriteStringValue("fefecBReg", FefecBReg);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
