﻿using System;
using System.Collections.Generic;

namespace CoreSAF.Models
{
    public partial class BdReposicionServicio
    {
        public int Id { get; set; }
        public int IdBodegaOrigen { get; set; }
        public int IdBodegaDestino { get; set; }
        public int IdDevolucionServicio { get; set; }
        public string IdDocumentoTipo { get; set; } = null!;
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaSistema { get; set; }
        public string Estado { get; set; } = null!;

        public virtual BdBodega IdBodegaDestinoNavigation { get; set; } = null!;
        public virtual BdBodega IdBodegaOrigenNavigation { get; set; } = null!;
        public virtual BdDevolucionServicio IdDevolucionServicioNavigation { get; set; } = null!;
        public virtual BdDocumentoTipo IdDocumentoTipoNavigation { get; set; } = null!;
    }
}
