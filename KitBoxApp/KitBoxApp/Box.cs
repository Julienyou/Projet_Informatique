using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBoxApp
{

    public class Box : INotifyPropertyChanged
    {
        private int height;
        private List<IAccessory> accessories = new List<IAccessory> { };
        private Cupboard cupboard;
        private string lateralColor;
        private string horizontalColor;
        private BoxConstraint boxConstraint;


        public Box(Cupboard cupboard)
        {
            this.cupboard = cupboard;
            this.boxConstraint = new BoxConstraint();
        }

        // INotifyPropertyChanged Member
        public event PropertyChangedEventHandler PropertyChanged;
        void Notify(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public void AddAccessory(IAccessory c)
        {
            accessories.Add(c);
        }

        public void RemoveAccessory(IAccessory c)
        {
            accessories.Remove(c);
        }

        public List<IAccessory> Accessories
        {
            get => accessories;
        }

        public int GetWidth()
        {
            return cupboard.Width;
        }

        public int Height
        {
            get => height;
            set
            {
                if(cupboard.Height-height+value >= cupboard.CupboardConstraint.MaxHeight)
                {
                    MessageBox.Show("You have reached max cupboard height", "Max Height", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    height = value;
                
                    ((Door)accessories[0]).DoorConstraint.Colors = ConstraintBuilder.GetAvailableDoorStyle(cupboard.Width, height);
                    if (!((Door)accessories[0]).DoorConstraint.Colors.Contains(((Door)accessories[0]).Color))
                    {
                        ((Door)accessories[0]).Color = ((Door)accessories[0]).DoorConstraint.Colors[0];
                    }
                    boxConstraint.VColors = ConstraintBuilder.GetAvailableVPaneColor(cupboard.Width, cupboard.Depth, height);
                    if (!boxConstraint.VColors.Contains(lateralColor))
                    {
                        lateralColor = boxConstraint.VColors[0];
                    }
                    Notify("Height");
                }
            }
        }

        public Cupboard Cupboard
        {
            get => cupboard;
        }

        public string LateralColor
        {
            get => lateralColor;
            set
            {
                lateralColor = value;
                Notify("LateralColor");
            }
        }

        public string HorizontalColor
        {
            get => horizontalColor;
            set
            {
                horizontalColor = value;
                Notify("HorizontalColor");
            }
        }

        public BoxConstraint BoxConstraint { get => boxConstraint; }
    }
}
