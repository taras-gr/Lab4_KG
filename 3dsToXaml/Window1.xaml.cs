using System.Windows;

namespace Lab5
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            CreateScene();
        }

        private void CreateScene()
        {
            ModelBase figure = new ModelBase("figure");
            this.FigureContainer.Children.Add(figure);
        }

    }
}
