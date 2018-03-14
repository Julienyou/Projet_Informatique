﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBoxApp
{
    class Box
    {
        private int height;
        private List<IAccessory> accessories;
        private int price;
        private List<Pane> panes;
        private Cupboard cupboard;

        public Box(int height, List<IAccessory> accessories, int price, List<Pane> panes, Cupboard cupboard)
        {
            this.height = height;
            this.accessories = accessories;
            this.price = price;
            this.panes = panes;
            this.cupboard = cupboard;
        }

        public int Price
        {
            get => price;
        }

        public void AddComponent(IAccessory c)
        {
            accessories.Add(c);
        }

        public void RemoveComponent(IAccessory c)
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
            get { return height; }
        }

        public List<Pane> Panes
        {
            get => panes;
        }
    }
}