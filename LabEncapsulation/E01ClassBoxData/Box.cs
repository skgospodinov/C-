using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double heigth;

        public Box(double length, double width, double heigth)
        {
            this.Length = length;
            this.Width = width;
            this.Height = heigth;
        }
        
        public double Length 
        {
            get => this.length;
            private set 
            {
                this.TrowIfInvalidSide(value, nameof(this.Length));
                this.length = value;
            }
        }
        public double Width
        {
            get => this.width;
            private set
            {
                this.TrowIfInvalidSide(value, nameof(this.Width));
                this.width = value;
            }
        }
        public double Height
        {
            get => this.heigth;
            private set
            {
                this.TrowIfInvalidSide(value,nameof(this.Height));

                this.heigth = value;
            }
        }

        private void TrowIfInvalidSide(double value, string side) 
        {
            if (value <= 0) 
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }
        public double SurfaceArea() 
        {
            return (2*this.length*this.width) + (2*this.length*this.heigth) + (2*this.width*this.heigth);
        }

        public double LateralSurfaceArea() 
        {
            return (2*this.length*this.heigth) + (2*this.width*this.heigth); 
        }
        public double Volume() 
        {
            return this.length*this.width*this.heigth;
        }
    }
}
