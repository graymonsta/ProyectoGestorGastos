using ProyectoGestorGastos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestorGastos.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        public IEnumerable<MenuOption> GetMenuOptions()
        {
            return new List<MenuOption>
            {
                new() { Titulo = "Dashboard",  Icono = "", Ruta = "Dashboard" },
                new() { Titulo = "Gastos",     Icono = "", Ruta = "Gastos"    },
                new() { Titulo = "Reportes",   Icono = "", Ruta = "Reportes"  },
                new() { Titulo = "Perfil",     Icono = "", Ruta = "Perfil"    },
            };
        }
    }
}
