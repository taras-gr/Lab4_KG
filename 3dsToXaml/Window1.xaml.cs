using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;

namespace _3dsToXaml
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
            //ModelBase sofa1 = new ModelBase("sofa");
            //this.FurnitureContainer.Children.Add(sofa1); //adds the first sofa to the middle of the floor
            //// move to the back edge of the floor
            //// This would be a -6 Z translation, but that would put the center of the sofa along the back edge.
            //// We want the back of the sofa along the back edge so we have to subtract half the depth of the sofa (roughly 1.2)
            //sofa1.Move(0, 0, -4.8, 0);

            //ModelBase sofa2 = new ModelBase("sofa");
            //this.FurnitureContainer.Children.Add(sofa2); //adds the second sofa to the middle of the floor
            //// rotate and move to the left edge of the floor
            //sofa2.Move(-4.8, 0, 0, 90);

            //ModelBase table = new ModelBase("table");
            //this.FurnitureContainer.Children.Add(table);

            ModelBase figureSolid = new ModelBase("figureSolid");
            this.FurnitureContainer.Children.Add(figureSolid);
            figureSolid.Move(5.5, 0, 0, -90);

            ModelBase tv = new ModelBase("tv");
            this.FurnitureContainer.Children.Add(tv);
            tv.Move(5.5, 0, 0, -90);
        }

        public Point3DCollection FloorPoints3D
        {
            get
            {
                double x = 6.0; // floor width / 2
                double z = 6.0; // floor length / 2
                double floorDepth = -0.2; // give the floor some depth so it's not a 2 dimensional plane

                Point3DCollection points = new Point3DCollection(20);
                Point3D point;
                //top of the floor
                point = new Point3D(-x, 0, z);// Floor Index - 0
                points.Add(point);
                point = new Point3D(x, 0, z);// Floor Index - 1
                points.Add(point);
                point = new Point3D(x, 0, -z);// Floor Index - 2
                points.Add(point);
                point = new Point3D(-x, 0, -z);// Floor Index - 3
                points.Add(point);
                //front side
                point = new Point3D(-x, 0, z);// Floor Index - 4
                points.Add(point);
                point = new Point3D(-x, floorDepth, z);// Floor Index - 5
                points.Add(point);
                point = new Point3D(x, floorDepth, z);// Floor Index - 6
                points.Add(point);
                point = new Point3D(x, 0, z);// Floor Index - 7
                points.Add(point);
                //right side
                point = new Point3D(x, 0, z);// Floor Index - 8
                points.Add(point);
                point = new Point3D(x, floorDepth, z);// Floor Index - 9
                points.Add(point);
                point = new Point3D(x, floorDepth, -z);// Floor Index - 10
                points.Add(point);
                point = new Point3D(x, 0, -z);// Floor Index - 11
                points.Add(point);
                //back side
                point = new Point3D(x, 0, -z);// Floor Index - 12
                points.Add(point);
                point = new Point3D(x, floorDepth, -z);// Floor Index - 13
                points.Add(point);
                point = new Point3D(-x, floorDepth, -z);// Floor Index - 14
                points.Add(point);
                point = new Point3D(-x, 0, -z);// Floor Index - 15
                points.Add(point);
                //left side
                point = new Point3D(-x, 0, -z);// Floor Index - 16
                points.Add(point);
                point = new Point3D(-x, floorDepth, -z);// Floor Index - 17
                points.Add(point);
                point = new Point3D(-x, floorDepth, z);// Floor Index - 18
                points.Add(point);
                point = new Point3D(-x, 0, z);// Floor Index - 19
                points.Add(point);

                return points;
            }
        }

        public Int32Collection FloorPointsIndices
        {
            get
            {
                int[] indices = new int[] { 0, 1, 2, 0, 2, 3, 4, 5, 7, 5, 6, 7, 8, 9, 11, 9, 10, 11, 12, 13, 15, 13, 14, 15, 16, 17, 19, 17, 18, 19 };
                return new Int32Collection(indices);
            }
        }

    }
}
