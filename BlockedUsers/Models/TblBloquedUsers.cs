namespace BlockedUsers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TblBloquedUsers
    {
        public int Id { get; set; }

        [StringLength(155)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public int? CidadeId { get; set; }
    }
}
