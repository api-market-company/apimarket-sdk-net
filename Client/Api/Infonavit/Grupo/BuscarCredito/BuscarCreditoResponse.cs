// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Api.Infonavit.Grupo.BuscarCredito
{
    [Obsolete("This class is obsolete. Use BuscarCreditoPostResponse instead.")]
    #pragma warning disable CS1591
    public class BuscarCreditoResponse : KiotaPosts.Client.Api.Infonavit.Grupo.BuscarCredito.BuscarCreditoPostResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Infonavit.Grupo.BuscarCredito.BuscarCreditoResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KiotaPosts.Client.Api.Infonavit.Grupo.BuscarCredito.BuscarCreditoResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Api.Infonavit.Grupo.BuscarCredito.BuscarCreditoResponse();
        }
    }
}