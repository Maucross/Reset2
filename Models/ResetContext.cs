using Microsoft.EntityFrameworkCore;

namespace Reset.Models
{
    public class ResetContext :  DbContext
    {
        public ResetContext(DbContextOptions<ResetContext> options) 
            : base (options) 
        {
            
        }
        public DbSet<Reset.Models.cliente> cliente { get; set; }
        public DbSet<Reset.Models.comprobante> comprobante { get; set; }
        public DbSet<Reset.Models.cotizacion> cotizacion { get; set; }
        public DbSet<Reset.Models.detalles_comprobante> detalles_comprobante { get; set; }
        public DbSet<Reset.Models.detalles_cotizacion> detalles_cotizacion { get; set; }
        public DbSet<Reset.Models.detalles_licitacion> detalles_licitacion { get; set; }
        public DbSet<Reset.Models.detalles_orden_compra> detalles_orden_compra { get; set; }
        public DbSet<Reset.Models.licitacion> licitacion { get; set; }
        public DbSet<Reset.Models.marca> marca { get; set; }
        public DbSet<Reset.Models.orden_compra> orden_compra { get; set; }
        public DbSet<Reset.Models.piezas> piezas { get; set; }
        public DbSet<Reset.Models.usuario> usuario { get; set; }

    }
}