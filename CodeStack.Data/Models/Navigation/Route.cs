using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CodeStack.Data.Models.Navigation {
    [Table("Routes", Schema = "Options")]
    public class Route : Base.IBase<Route> {
        [Key]
        public int RouteID { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string Routerlink { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Details { get; set; }
        public int NavOrder { get; set; }
        private readonly CodeStackContext _context;
        public Route() { }
        public Route(CodeStackContext context) {
            _context = context;
        }
        public Route Default() {
            Route x = new Route() {
                RouteID = -1,
                Name = "",
                Routerlink = "",
                Details = "",
                NavOrder = -1
            };
            return x;
        }
        public List<Route> Get() {
            return _context.Route.OrderBy(x => x.NavOrder).ToList();
        }

        public Route Get(int RouteID) {
            return _context.Route.FirstOrDefault(x => x.RouteID == RouteID);
        }

        public void Post() {
            _context.Route.Add(this);
            _context.SaveChanges();
        }

        public void Put() {
            _context.Route.Update(this);
            _context.SaveChanges();
        }
        public void Delete() {
            _context.Route.Remove(this);
            _context.SaveChanges();
        }

        public void Delete(int RouteID) {
            var route = _context.Route.FirstOrDefault(x => x.RouteID == RouteID);
            if (route == null) return;
            _context.Route.Remove(route);
            _context.SaveChanges();
        }

    }
}