using App1.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace App1;

public class TemplateSelector : DataTemplateSelector
{
    public DataTemplate? RedTemplate { get; set; }
    public DataTemplate? GreenTemplate { get; set; }

    protected override DataTemplate? SelectTemplateCore(object item, DependencyObject container)
    {
        return (item as ContentViewModel) switch
        {
            GreenContentViewModel => GreenTemplate,
            RedContentViewModel => RedTemplate,
            _ => new DataTemplate()
        };
    }
}