using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Examen_Mvvm.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private decimal producto1;
    [ObservableProperty] private decimal producto2;
    [ObservableProperty] private decimal producto3;
    [ObservableProperty] private decimal subtotal;
    [ObservableProperty] private decimal descuento;
    [ObservableProperty] private decimal total;

    [RelayCommand]
    private void Calcular()
    {
        Subtotal = Producto1 + Producto2 + Producto3;

        if (Subtotal >= 1000 && Subtotal <= 4999.99m)
            Descuento = Subtotal * 0.10m;
        else if (Subtotal >= 5000 && Subtotal <= 9999.99m)
            Descuento = Subtotal * 0.20m;
        else if (Subtotal >= 10000 && Subtotal <= 19999.99m)
            Descuento = Subtotal * 0.30m;
        else
            Descuento = 0;

        Total = Subtotal - Descuento;
    }

    [RelayCommand]
    private void Limpiar()
    {
        Producto1 = Producto2 = Producto3 = Subtotal = Descuento = Total = 0;
    }
}