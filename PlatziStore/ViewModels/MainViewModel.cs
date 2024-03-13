using MvvmHelpers.Commands;
using PlatziStore.Models.DTOs;
using PlatziStore.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PlatziStore.ViewModels
{
    internal class MainViewModel
    {

        ProductoService productoService = new();
        CategoriaService categoriaService = new();
        public Producto Producto { get; set; } = new();

        public ObservableCollection<Categoria> Categorias { get; set; } = new();

        public ObservableCollection<Producto> Productos { get; set; } = new();

        public ICommand AgregarProductoCommand { get; set; }
        public ICommand VerDetallesProductoCommand { get; set; }

        public MainViewModel()
        {
            CargarProductos();
            CargarCategorias();
            AgregarProductoCommand = new AsyncCommand(AgregarProducto);
            VerDetallesProductoCommand = new AsyncCommand(VerDetallesProducto);
        }

      
        async void CargarProductos()
        {
            var productos = await productoService.GetAll();
            foreach (var producto in productos)
            {
                Productos.Add(producto);
            }
        }

        public async void CargarCategorias()
        {
            var categorias = await categoriaService.GetAll();
            foreach (var categoria in categorias)
            {
                Categorias.Add(categoria);
            }
        }

        private async Task AgregarProducto()
        {
           await productoService.Create(Producto);
        }

        private async Task VerDetallesProducto()
        {
            await Shell.Current.GoToAsync("ProductoDetalles");
        }


    }
}
