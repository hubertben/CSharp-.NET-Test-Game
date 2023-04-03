
using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace testGame
{
    public class Circle
    { 

        private float x, y;
        private float radius;
        private Color color;
        private Ellipse ellipse;
   
        public Circle(float x_, float y_, float radius_, Color color_, Canvas canvas_)
        {
            x = x_;
            y = y_;
            radius = radius_;
            color = color_;


            ellipse = new Ellipse();
            ellipse.Width = radius * 2;
            ellipse.Height = radius * 2;
            
            SolidColorBrush brush = new SolidColorBrush(color);
            ellipse.Fill = brush;

            canvas_.Children.Add(ellipse);
        }

        public void draw()
        {
            Canvas.SetLeft(ellipse, x);
            Canvas.SetTop(ellipse, y);
        }

        public void move(float dx, float dy)
        {
            x += dx;
            y += dy;
        }

    }
}
