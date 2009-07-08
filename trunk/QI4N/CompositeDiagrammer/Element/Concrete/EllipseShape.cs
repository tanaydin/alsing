﻿namespace CompositeDiagrammer
{
    using System.Drawing;
    using System.Drawing.Drawing2D;

    using QI4N.Framework;

    [Mixins(typeof(EllipseShapeMixin))]
    public interface EllipseShape : ElementComposite, Positional, Rotatable, Bordered, Filled
    {
    }

    public class EllipseShapeMixin : AbstractShapeMixin
    {
        public override GraphicsPath GetPath()
        {
            var shape = new GraphicsPath();
            var bounds = new Rectangle(this.state.Left, this.state.Top, this.state.Width, this.state.Height);
            shape.AddEllipse(bounds);
            return shape;
        }
    }
}