using System;
using System.Collections.Generic;

class GraphicsEditor
{
    private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

    public void AddPrimitive(GraphicPrimitive primitive)
    {
        primitives.Add(primitive);
    }

    public void DrawPrimitives()
    {
        foreach (var primitive in primitives)
        {
            primitive.Draw();
        }
    }
}
