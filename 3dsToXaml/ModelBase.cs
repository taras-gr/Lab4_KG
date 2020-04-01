using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media.Media3D;
using System.Diagnostics;

namespace _3dsToXaml
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
