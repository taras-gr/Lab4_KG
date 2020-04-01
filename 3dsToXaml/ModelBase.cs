using System.Windows;
using System.Windows.Media.Media3D;
using System.Diagnostics;

namespace Lab5
{
    class ModelBase : UIElement3D
    {
        public ModelBase(string resourceKey)
        {
            this.Visual3DModel = Application.Current.Resources[resourceKey] as Model3DGroup;
            Debug.Assert(this.Visual3DModel != null);
        }
    }
}
