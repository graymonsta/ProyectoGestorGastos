using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProyectoGestorGastos.Models;
using ProyectoGestorGastos.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestorGastos.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly IMenuRepository _menuRepo;

        public ObservableCollection<MenuOption> MenuOptions { get; } = new();

        [ObservableProperty]
        private object? currentViewModel;

        public MainViewModel(IMenuRepository menuRepo)
        {
            _menuRepo = menuRepo;

            foreach (var option in _menuRepo.GetMenuOptions())
                MenuOptions.Add(option);

            CurrentViewModel = new DashboardViewModel();
        }

        [RelayCommand]
        private void Navigate(MenuOption? option)
        {
            if (option is null) return;

            CurrentViewModel = option.Ruta switch
            {
                "Dashboard" => new DashboardViewModel(),
                "Gastos" => new GastosViewModel(),
                "Reportes" => new ReportesViewModel(),
                "Perfil" => new PerfilViewModel()
            };
        }
    }
}
